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
	public partial class ContentEditor : UserControl
	{
		public ContentEditor()
		{
			InitializeComponent();
		}

		public void SetDefault()
		{
			jsonPreview.SetJSON("{\n\t\"Version\": 1,\n\t\"Name\": \"Content File 1\"\n}");
		}
	}
}