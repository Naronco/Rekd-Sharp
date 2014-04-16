using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = System.Math;

namespace RekdEngine.UtilMath.Algorithm
{
	public class BezierCurve
	{
		public List<Vector2f> Points;
		protected Dictionary<float, Vector2f> Saved;

		public BezierCurve()
		{
			Points = new List<Vector2f>();
			Saved = new Dictionary<float, Vector2f>();
		}

		public Vector2f Calculate(float t, bool useMem, bool forceRecalc)
		{
			if (useMem && !forceRecalc)
			{
				if (Saved.ContainsKey(t)) return Saved[t];
			}

			float b = 0;
			Vector2f res = new Vector2f();
			int n = Points.Count - 1;
			for (int i = 0; i <= n; i++)
			{
				b = MathExt.CalcBinomialCoefficient(n, i);
				res += b * (float)M.Pow(1 - t, (float)(n - i)) * (float)M.Pow(t, (float)i) * Points[i];
			}
			if (useMem) Saved[t] = res;
			return res;
		}

		public Vector2f Calculate(float t)
		{
			return Calculate(t, false, false);
		}
	}
}