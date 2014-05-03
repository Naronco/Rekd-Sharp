using Newtonsoft.Json;
using RekdEngine.Content;
using RekdEngine.Render;
using RekdEngine.UtilMath;
using RekdFileCompiler.JSON;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdFileCompiler.Controls
{
	public partial class ContentEditor : UserControl
	{
		private IntHandle version;
		private StringHandle name;
		private StringHandle type;
		private List<Control> controls;
		private JSONFormat file;
		private RekdEngine.Content.Effect f;
		private long time;
		private bool ShaderInitialized;
		private Dictionary<string, string> workingShaderParams;

		public ContentEditor()
		{
			InitializeComponent();
			file = new JSONFormat();
			file.Name = "Content File 1";
			file.Version = 1;
			file.Type = ContentType.Mesh;
		}

		public void SetDefault()
		{
			SetJSON();
		}

		public void SetJSON()
		{
			jsonPreview.SetJSON(JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }).Replace("  ", "\t"));
		}

		public Panel CreateContainer(string name)
		{
			Panel p = new Panel();
			p.Left = 0;
			p.Top = 0;
			p.Padding = new Padding(5);
			p.Height = 50;
			p.Dock = DockStyle.Top;

			Label label = new Label();
			label.AutoSize = false;
			label.Top = 15;
			label.Left = 15;
			label.Dock = DockStyle.Top;
			label.Height = 15;
			label.TextAlign = ContentAlignment.MiddleLeft;
			label.Text = " == " + name + " == ";

			p.Controls.Add(label);
			return p;
		}

		public ControlCollection Reverse(ControlCollection c)
		{
			List<Control> n = new List<Control>();
			foreach (Control co in c)
			{
				n.Add(co);
			}
			n.Reverse();
			ControlCollection b = new ControlCollection(c.Owner);
			b.AddRange(n.ToArray());
			return b;
		}

		public StringHandle AddStringValue(string name, string defaultText, Action<string> change)
		{
			StringHandle ret = new StringHandle() { Value = defaultText };
			Panel p = CreateContainer(name);
			TextBox changable = new TextBox();
			changable.Text = defaultText;
			changable.Dock = DockStyle.Top;
			changable.TextChanged += (s, e) => { ret.Value = changable.Text; change(changable.Text); };
			p.Controls.Add(changable);
			Reverse(p.Controls);
			controls.Add(p);
			return ret;
		}

		public IntHandle AddIntValue(string name, int min, int max, int defaultValue, Action<int> change)
		{
			IntHandle ret = new IntHandle() { Value = defaultValue };
			Panel p = CreateContainer(name);
			controls.Add(p);
			NumericUpDown changable = new NumericUpDown();
			changable.Maximum = max;
			changable.Minimum = min;
			changable.Value = defaultValue;
			changable.Increment = 1;
			changable.Dock = DockStyle.Top;
			changable.TextChanged += (s, e) => { ret.Value = (int)changable.Value; change((int)changable.Value); };
			p.Controls.Add(changable);
			Reverse(p.Controls);
			controls.Add(p);
			return ret;
		}

		public StringHandle AddDropDownStringValue(string name, Action<string> change, params string[] values)
		{
			if (values.Length == 0) return null;
			StringHandle ret = new StringHandle() { Value = values[0] };
			Panel p = CreateContainer(name);
			ComboBox changable = new ComboBox();
			changable.DropDownStyle = ComboBoxStyle.DropDownList;
			changable.Items.AddRange(values);
			changable.Text = values[0];
			changable.Dock = DockStyle.Top;
			changable.SelectedValueChanged += (s, e) => { ret.Value = changable.Text; change(changable.Text); };
			p.Controls.Add(changable);
			Reverse(p.Controls);
			controls.Add(p);
			return ret;
		}

		public void AddLine()
		{
			Panel p = new Panel();
			p.Top = 0;
			p.Left = 0;
			p.Dock = DockStyle.Top;
			p.Height = 2;
			p.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
			controls.Add(p);
		}

		private void ContentEditor_Load(object sender, EventArgs e)
		{
			controls = new List<Control>();
			version = AddIntValue("Version", 1, 1, 1, (i) => { file.Version = i; SetJSON(); });
			name = AddStringValue("Name", "Content File 1", (s) => { file.Name = s; SetJSON(); });
			type = AddDropDownStringValue("Type", (s) => { file.Type = (ContentType)Enum.Parse(typeof(ContentType), s); SetJSON(); }, "Mesh", "Texture", "Shader", "Material", "Object");

			controls.Reverse();
			props.Controls.AddRange(controls.ToArray());
			direct3DPreview1.Initialize();

			shaderVariables.SmallImageList = new ImageList();
			shaderVariables.SmallImageList.Images.Add(new Bitmap(1, 1));
			shaderVariables.SmallImageList.Images.Add(SystemIcons.Exclamation);

			workingShaderParams = new Dictionary<string, string>();
		}

		public void FillShaderParams()
		{
			workingShaderParams.Clear();
			foreach (ListViewItem i in shaderVariables.Items)
			{
				if (workingShaderParams.ContainsKey(i.SubItems[0].Text))
				{
					i.ImageIndex = 1;
				}
				else
				{
					workingShaderParams.Add(i.SubItems[0].Text, i.SubItems[2].Text);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (texDictionary.SelectedItems.Count == 0) return;
			foreach (ListViewItem i in texDictionary.SelectedItems)
			{
				texDictionary.Items.Remove(i);
			}
			FillShaderParams();
		}

		public void HandleShaderVariables()
		{
			List<string> toRemove = new List<string>();
			foreach (KeyValuePair<string, string> i in workingShaderParams)
			{
				try
				{
					switch (i.Value)
					{
						case "%WorldMatrix":
							f.SetMatrix(i.Key, direct3DPreview1.Device.GetTransform(TransformState.World));
							break;

						case "%ViewMatrix":
							f.SetMatrix(i.Key, direct3DPreview1.Device.GetTransform(TransformState.View));
							break;

						case "%ProjectionMatrix":
							f.SetMatrix(i.Key, direct3DPreview1.Device.GetTransform(TransformState.Projection));
							break;

						case "%TexelSize":
							f.SetVector(i.Key, new Vector2f(1 / direct3DPreview1.ViewportWidth, 1 / direct3DPreview1.ViewportHeight));
							break;

						case "%TimeMS":
							f.SetValue(i.Key, time);
							break;
					}
				}
				catch
				{
					foreach (ListViewItem it in texDictionary.Items)
					{
						if (it.SubItems[0].Text == i.Key)
							it.ImageIndex = 1;
					}
					toRemove.Add(i.Key);
				}
			}
			foreach (string s in toRemove)
			{
				workingShaderParams.Remove(s);
			}
		}

		public void LoadShaderPreview()
		{
			ShaderInitialized = true;
			f = direct3DPreview1.Content.LoadString<RekdEngine.Content.Effect>("float4 f():COLOR{return 1;}technique t{pass p{PixelShader=compile ps_2_0 f();}}");

			Stopwatch sw = new Stopwatch();
			Texture2D tex = direct3DPreview1.Content.Load<Texture2D>("example.png");
			direct3DPreview1.Start((Width, Height) =>
			{
				sw.Start();
				direct3DPreview1.spriteBatch.Begin(RekdEngine.Core.Color.Black);

				HandleShaderVariables();

				f.Begin();
				f.BeginPass(0);

				int d = Math.Min(Width - 64, Height - 64);

				tex.Bind(0);
				direct3DPreview1.spriteBatch.DrawPrimitive(new RekdEngine.UtilMath.Rectangle((Width - d) * 0.5f, -(Height - d) * 0.5f, d, d));

				f.EndPass();
				f.End();

				direct3DPreview1.spriteBatch.End();

				direct3DPreview1.Device.Present();
				sw.Stop();
				time += sw.ElapsedMilliseconds;
			});
			f.Dispose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (texName.Text.Trim() != "" && texPath.Text.Trim() != "")
				texDictionary.Items.Add(new ListViewItem(new string[] { texName.Text, texPath.Text }));
			texName.Text = "";
			texPath.Text = "";
			texName.Focus();

			Dictionary<string, string> namePathPairs = new Dictionary<string, string>();
			foreach (ListViewItem i in texDictionary.Items)
			{
				namePathPairs.Add(i.Text, i.SubItems[1].Text);
			}
			file.Textures = namePathPairs;
			SetJSON();
		}

		private void loadMeshFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "3D Meshes|*.obj; *.fbx; *.n3dm; *.n3dbm; *.x";
			DialogResult d = ofd.ShowDialog();
			if (d == DialogResult.OK)
			{
				string f = ofd.FileName;
				string ext = Path.GetExtension(f);
				switch (ext.ToLower())
				{
					case ".obj":
						break;

					case ".fbx":
						break;

					case ".n3dm":
						break;

					case ".n3dbm":
						break;

					case ".x":
						break;
				}

				//meshPath.Text = f;
			}
		}

		private void runShaderButton_Click(object sender, EventArgs e)
		{
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AddShaderItem asi = new AddShaderItem();
			asi.ShowDialog();
			shaderVariables.Items.Add(new ListViewItem(new[] { asi.Name, asi.Type, asi.Default }));
			if (file.Shader.Variables == null)
			{
				file.Shader = new JSONShaderFormat() { Variables = new List<string>(), Textures = new Dictionary<string, string>() };
			}
			file.Shader.Variables.Clear();
			foreach (ListViewItem i in shaderVariables.Items)
			{
				file.Shader.Variables.Add(i.Text);
			}
			SetJSON();
			FillShaderParams();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (shaderVariables.SelectedItems.Count == 0) return;
			foreach (ListViewItem i in shaderVariables.SelectedItems)
			{
				shaderVariables.Items.Remove(i);
			}
			file.Shader.Variables.Clear();
			foreach (ListViewItem i in shaderVariables.Items)
			{
				file.Shader.Variables.Add(i.Text);
			}
			SetJSON();
			FillShaderParams();
		}

		public string Prompt(string text, string def)
		{
			Form f = new Form();
			f.Width = 400;
			f.Height = 150;
			f.FormBorderStyle = FormBorderStyle.FixedDialog;
			f.Padding = new Padding(10);
			Button bt = new Button();
			bt.Dock = DockStyle.Bottom;
			bt.Text = "OK";
			bt.Focus();
			bt.Click += (s, e) =>
			{
				f.Close();
			};
			f.Controls.Add(bt);
			TextBox tb = new TextBox();
			tb.Dock = DockStyle.Top;
			tb.Text = def;
			f.Controls.Add(tb);
			Label lb = new Label();
			lb.Text = "Please enter the " + text + ":";
			lb.AutoSize = false;
			lb.TextAlign = ContentAlignment.MiddleCenter;
			lb.Dock = DockStyle.Top;
			f.Controls.Add(lb);
			f.StartPosition = FormStartPosition.CenterParent;
			f.ShowDialog();
			return tb.Text;
		}

		private void addWVP_Click(object sender, EventArgs e)
		{
			shaderVariables.Items.Add(new ListViewItem(new[] { Prompt("World Matrix Name", "World"), "Matrix4x4", "%WorldMatrix" }));
			shaderVariables.Items.Add(new ListViewItem(new[] { Prompt("View Matrix Name", "View"), "Matrix4x4", "%ViewMatrix" }));
			shaderVariables.Items.Add(new ListViewItem(new[] { Prompt("Projection Matrix Name", "Projection"), "Matrix4x4", "%ProjectionMatrix" }));
			if (file.Shader.Variables == null)
			{
				file.Shader = new JSONShaderFormat() { Variables = new List<string>(), Textures = new Dictionary<string, string>() };
			}
			file.Shader.Variables.Clear();
			foreach (ListViewItem i in shaderVariables.Items)
			{
				file.Shader.Variables.Add(i.Text);
			}
			SetJSON();
			FillShaderParams();
		}

		private void addTexelSize_Click(object sender, EventArgs e)
		{
			shaderVariables.Items.Add(new ListViewItem(new[] { Prompt("Texel Size Name", "TexelSize"), "Vector2", "%TexelSize" }));
			if (file.Shader.Variables == null)
			{
				file.Shader = new JSONShaderFormat() { Variables = new List<string>(), Textures = new Dictionary<string, string>() };
			}
			file.Shader.Variables.Clear();
			foreach (ListViewItem i in shaderVariables.Items)
			{
				file.Shader.Variables.Add(i.Text);
			}
			SetJSON();
			FillShaderParams();
		}

		private void addTime_Click(object sender, EventArgs e)
		{
			shaderVariables.Items.Add(new ListViewItem(new[] { Prompt("Time Name", "Time"), "Number", "%TimeMS" }));
			if (file.Shader.Variables == null)
			{
				file.Shader = new JSONShaderFormat() { Variables = new List<string>(), Textures = new Dictionary<string, string>() };
			}
			file.Shader.Variables.Clear();
			foreach (ListViewItem i in shaderVariables.Items)
			{
				file.Shader.Variables.Add(i.Text);
			}
			SetJSON();
			FillShaderParams();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 1 && !ShaderInitialized)
				LoadShaderPreview();
		}
	}

	public class StringHandle
	{
		public string Value { get; set; }
	}

	public class IntHandle
	{
		public int Value { get; set; }
	}
}