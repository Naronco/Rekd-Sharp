using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdFileCompiler.Controls
{
	public partial class JsonPreview : UserControl
	{
		public Color StringColor = Color.FromArgb(37, 105, 124);
		public Color DefaultColor = Color.FromArgb(64, 64, 64);
		public Color ColonColor = Color.FromArgb(197, 0, 110);
		public Color NumberColor = Color.FromArgb(173, 155, 104);

		public JsonPreview()
		{
			InitializeComponent();
		}

		public void SetColor(Color c)
		{
			codePreview.SelectionColor = c;
		}

		public void Append(char t)
		{
			codePreview.AppendText("" + t);
		}

		public void SetJSON(string json)
		{
			codePreview.Clear();
			codeLines.Clear();
			bool isString = false;
			bool isNumber = false;
			bool doubleString = false;
			char prev = ' ';
			Color? nextColor = null;
			foreach (char c in json)
			{
				if (prev == ':' && !isString)
				{
					SetColor(DefaultColor);
				}
				if (c == ':' && !isString)
				{
					SetColor(ColonColor);
				}
				else if (c == '"' && prev != '\\')
				{
					if (isString && doubleString)
					{
						isString = false;
						nextColor = DefaultColor;
					}
					else if (!isString)
					{
						isString = true;
						doubleString = true;
						SetColor(StringColor);
					}
				}
				else if (c == '\'' && prev != '\\')
				{
					if (isString && !doubleString)
					{
						isString = false;
						nextColor = DefaultColor;
					}
					else if (!isString)
					{
						isString = true;
						doubleString = false;
						SetColor(StringColor);
					}
				}
				else if (!isString)
				{
					if (c == '0' ||
					   c == '1' ||
					   c == '2' ||
					   c == '3' ||
					   c == '4' ||
					   c == '5' ||
					   c == '6' ||
					   c == '7' ||
					   c == '8' ||
					   c == '9' ||
					   (c == '.' && isNumber))
					{
						isNumber = true;
						SetColor(NumberColor);
					}
					else
					{
						isNumber = false;
						SetColor(DefaultColor);
					}
				}

				Append(c);

				if (nextColor != null)
				{
					SetColor((Color)nextColor);
					nextColor = null;
				}

				prev = c;
			}

			codeLines.SelectionAlignment = HorizontalAlignment.Right;
			for (int i = 1; i <= codePreview.Lines.Length; i++)
			{
				codeLines.AppendText(i + "\n");
			}
		}

		public void UpdateZoom()
		{
			zooms.Text = Math.Round(codePreview.ZoomFactor * 100) + " %";
			codeLines.ZoomFactor = codePreview.ZoomFactor;
		}

		private void codePreview_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				UpdateZoom();
			}
		}

		private void codePreview_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				UpdateZoom();
			}
		}

		public void SetZoom()
		{
			string zoom = zooms.Text.Replace("%", "").Trim();
			int z;
			if (int.TryParse(zoom, out z))
			{
				codePreview.ZoomFactor = z / 100.0f;
			}
			UpdateZoom();
			codePreview.Invalidate();
		}

		private void zooms_Leave(object sender, EventArgs e)
		{
			SetZoom();
		}

		private void zooms_SelectionChangeCommitted(object sender, EventArgs e)
		{
			SetZoom();
		}

		private void zooms_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetZoom();
		}

		private void JsonPreview_Load(object sender, EventArgs e)
		{
			zooms.DrawMode = DrawMode.OwnerDrawVariable;
			zooms.DrawItem += zooms_DrawItem;
			zooms.MeasureItem += zooms_MeasureItem;
			zooms.DropDownHeight = 300;
		}

		private void zooms_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 10;
		}

		private void zooms_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.DrawFocusRectangle();
			e.Graphics.DrawString(zooms.Items[e.Index].ToString(), new Font(new FontFamily("Segoe UI"), 6, FontStyle.Regular), new SolidBrush(Color.Black), e.Bounds);
		}
	}
}