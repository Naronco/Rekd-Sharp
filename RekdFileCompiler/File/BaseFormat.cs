using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdFileCompiler.File
{
	public class BaseFormat
	{
		public string Name { get; set; }

		public int Version { get; set; }

		public ContentType Type { get; set; }
	}
}