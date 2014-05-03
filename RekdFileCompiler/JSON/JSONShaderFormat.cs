using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdFileCompiler.JSON
{
	public struct JSONShaderFormat
	{
		public List<string> Variables { get; set; }

		public Dictionary<string, string> Textures { get; set; }

		public string File { get; set; }

		public string Content { get; set; }
	}
}