using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdFileCompiler.JSON
{
	public struct JSONFormat
	{
		[JsonProperty(Required = Required.Always)]
		public string Name { get; set; }

		[JsonProperty(Required = Required.Always)]
		public int Version { get; set; }

		[JsonProperty(Required = Required.Always)]
		[JsonConverter(typeof(StringEnumConverter))]
		public ContentType Type { get; set; }

		public string Mesh { get; set; }

		public Dictionary<string, string> Textures { get; set; }

		public JSONShaderFormat Shader { get; set; }
	}
}