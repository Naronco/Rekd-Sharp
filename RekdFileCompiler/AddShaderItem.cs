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
	public partial class AddShaderItem : Form
	{
		public string Name { get; set; }

		public string Type { get; set; }

		public string Default { get; set; }

		public AddShaderItem()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Name = name.Text;
			Type = type.Text;
			Default = def.Text;
			Close();
		}
	}
}