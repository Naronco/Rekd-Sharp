using Newtonsoft.Json;
using RekdFileCompiler.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			jsonPreview.SetJSON(Regex.Replace(JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }).Replace("  ", "\t"), @",\s{2,}", ",\n\t"));
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
			p.BackColor = Color.FromArgb(230, 230, 230);
			controls.Add(p);
		}

		private void ContentEditor_Load(object sender, EventArgs e)
		{
			controls = new List<Control>();
			version = AddIntValue("Version", 1, 1, 1, (i) => { file.Version = i; SetJSON(); });
			name = AddStringValue("Name", "Content File 1", (s) => { file.Name = s; SetJSON(); });
			type = AddDropDownStringValue("Type", (s) => { file.Type = (ContentType)Enum.Parse(typeof(ContentType), s); SetJSON(); }, "Mesh", "Texture", "Shader", "Material", "Object");
			AddLine();
			name = AddStringValue("Mesh", "", (s) => { file.Mesh = s; if (s.Trim() == "") file.Mesh = null; SetJSON(); });
			controls.Reverse();
			props.Controls.AddRange(controls.ToArray());
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