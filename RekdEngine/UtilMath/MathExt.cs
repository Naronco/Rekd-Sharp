using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public class MathExt
	{
		public static float CalcBinomialCoefficient(int n, int k)
		{
			return (float)(MathExt.Factorial(n) / (float)(MathExt.Factorial(k) * MathExt.Factorial(n - k)));
		}

		public static int Factorial(int r)
		{
			int res = 1;
			for (int i = 1; i <= r; i++)
				res = res * i;
			return res;
		}

		public static float ToRadians(float deg)
		{
			return deg * 0.0174532925f;
		}

		public static float ToDegrees(float rad)
		{
			return rad * 57.2957795f;
		}
	}
}