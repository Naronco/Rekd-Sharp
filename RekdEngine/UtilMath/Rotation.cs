using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Rotation
	{
		public float S, C;

		public Rotation(float angle)
		{
			S = (float)Math.Sin(angle);
			C = (float)Math.Cos(angle);
		}

		public void Set(float angle)
		{
			S = (float)Math.Sin(angle);
			C = (float)Math.Cos(angle);
		}

		public void SetIdentity()
		{
			S = 0.0f;
			C = 1.0f;
		}

		public float GetAngle()
		{
			return (float)Math.Atan2(S, C);
		}

		public Vector2f GetXAxis()
		{
			return new Vector2f(C, S);
		}

		public Vector2f GetYAxis()
		{
			return new Vector2f(-S, C);
		}

		public static Vector2f operator *(Rotation q, Vector2f v)
		{
			return new Vector2f(q.C * v.X - q.S * v.Y, q.S * v.X + q.C * v.Y);
		}

		public Vector2f MulT(Vector2f v)
		{
			return new Vector2f(C * v.X + S * v.Y, -S * v.X + C * v.Y);
		}
	}
}