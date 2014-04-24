using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Rectangle
	{
		public float X, Y, Width, Height;

		public Rectangle(Vector2f pos, Vector2f size)
		{
			X = pos.X;
			Y = pos.Y;
			Width = size.X;
			Height = size.Y;
		}

		public Rectangle(Vector2f pos, float w, float h)
		{
			X = pos.X;
			Y = pos.Y;
			Width = w;
			Height = h;
		}

		public Rectangle(float x, float y, float w, float h)
		{
			X = x;
			Y = y;
			Width = w;
			Height = h;
		}
	}
}