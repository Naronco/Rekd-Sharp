using RekdEngine.UtilMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.Render
{
	public struct VertexPositionTextureColor
	{
		public Vector4f Position { get; set; }

		public Vector2f TexCoord { get; set; }

		public int Color { get; set; }
	}
}