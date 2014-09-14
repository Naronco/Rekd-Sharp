using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdFileCompiler
{
	public partial class FileCompiler : Form
	{
		public FileCompiler()
		{
			InitializeComponent();
		}

		public void ResetFormat(RichTextBox tb)
		{
			tb.SelectionColor = Color.FromArgb(64, 64, 64);
		}

		public void SetString(RichTextBox tb)
		{
			tb.SelectionColor = Color.FromArgb(37, 105, 124);
		}

		private void FileCompiler_Load(object sender, EventArgs e)
		{
		}
	}
}