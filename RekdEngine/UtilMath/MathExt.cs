using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

		/// <summary>
		/// This is slower
		/// </summary>
		/// <param name="x">Value</param>
		/// <returns>Inverse Squareroot</returns>
		public static float ApproxInvSqrt(float x)
		{
			FloatIntUnion u;
			u.i = 0;
			u.x = x;
			float xhalf = 0.5f * x;
			u.i = 0x5f3759df - (u.i >> 1);
			x = u.x;
			x = x * (1.5f - xhalf * x * x);
			return x;
		}

		public static Vector2f Min(Vector2f a, Vector2f b)
		{
			return new Vector2f(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));
		}

		public static Vector2f Max(Vector2f a, Vector2f b)
		{
			return new Vector2f(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y));
		}

		public static float Epsilon = 1.192092896e-07F;

		[StructLayout(LayoutKind.Explicit)]
		private struct FloatIntUnion
		{
			[FieldOffset(0)]
			public float x;

			[FieldOffset(0)]
			public int i;
		}
	}
}