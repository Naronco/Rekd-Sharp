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
	public partial class OpenFileControl : UserControl
	{
		public event EventHandler<string> OnChange;

		public string Filter { get; set; }

		public OpenFileControl()
		{
			InitializeComponent();
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = Filter;
			DialogResult r = d.ShowDialog();
			if (r == DialogResult.OK)
			{
				if (OnChange != null)
					OnChange(this, d.FileName);
				string file = d.FileName.Replace('\\', '/');
				fileName.Clear();
				fileName.SelectionFont = new System.Drawing.Font(fileName.SelectionFont.FontFamily, fileName.SelectionFont.SizeInPoints, FontStyle.Regular);
				fileName.SelectionAlignment = HorizontalAlignment.Center;
				fileName.AppendText(file.Substring(0, file.LastIndexOf('/') + 1));
				fileName.SelectionFont = new System.Drawing.Font(fileName.SelectionFont.FontFamily, fileName.SelectionFont.SizeInPoints, FontStyle.Bold);
				fileName.AppendText(file.Substring(file.LastIndexOf('/') + 1));
			}
		}
	}
}