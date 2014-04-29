using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Transform
	{
		public Transform(Vector2f pos, Rotation rot)
		{
			P = pos;
			Q = rot;
		}

		public void SetIdentity()
		{
			P.Set(0, 0);
			Q.SetIdentity();
		}

		public void Set(Vector2f pos, float rot)
		{
			P = pos;
			Q.Set(rot);
		}

		public static Vector2f operator *(Transform T, Vector2f v)
		{
			float x = (T.Q.C * v.X - T.Q.S * v.Y) + T.P.X;
			float y = (T.Q.S * v.X + T.Q.C * v.Y) + T.P.Y;

			return new Vector2f(x, y);
		}

		public Vector2f P;
		public Rotation Q;
	}
}