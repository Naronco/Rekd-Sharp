using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Sweep
	{
		private Vector2f localCenter;
		private Vector2f c0, c;
		private float a0, a;
		private float alpha0;

		public void GetTransform(Transform xf, float beta)
		{
			xf.P = (1 - beta) * c0 + beta * c;
			float angle = (1 - beta) * a0 + beta * a;
			xf.Q.Set(angle);
			xf.P -= xf.Q * localCenter;
		}

		public void Advance(float alpha)
		{
			if (alpha0 < 1.0f)
			{
				float beta = (alpha - alpha0) / (1.0f - alpha0);
				c0 += beta * (c - c0);
				a0 += beta * (a - a0);
				alpha0 = alpha;
			}
		}

		public void Normalize()
		{
			float twoPi = 2.0f * 3.1415926f;
			float d = twoPi * (float)Math.Floor(a0 / twoPi);
			a0 -= d;
			a -= d;
		}
	}
}