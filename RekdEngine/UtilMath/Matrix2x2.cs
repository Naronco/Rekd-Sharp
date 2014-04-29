using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Matrix2x2
	{
		public float M00, M01;
		public float M10, M11;

		public float this[int x, int y]
		{
			get
			{
				if (x == 0)
				{
					if (y == 0)
					{
						return M00;
					}
					else if (y == 1)
					{
						return M01;
					}
				}
				else if (x == 1)
				{
					if (y == 0)
					{
						return M10;
					}
					else if (y == 1)
					{
						return M11;
					}
				}
				return 0;
			}

			set
			{
				if (x == 0)
				{
					if (y == 0)
					{
						M00 = value;
					}
					else if (y == 1)
					{
						M01 = value;
					}
				}
				else if (x == 1)
				{
					if (y == 0)
					{
						M10 = value;
					}
					else if (y == 1)
					{
						M11 = value;
					}
				}
			}
		}

		public Matrix2x2(float M00 = 1, float M01 = 0, float M10 = 0, float M11 = 1)
		{
			this.M00 = M00;
			this.M01 = M01;
			this.M10 = M10;
			this.M11 = M11;
		}

		public Matrix2x2 SetIdentity()
		{
			return Set(1, 0, 0, 1);
		}

		public Matrix2x2 Set(float M00, float M01, float M10, float M11)
		{
			this.M00 = M00;
			this.M01 = M01;
			this.M10 = M10;
			this.M11 = M11;
			return this;
		}

		public Matrix2x2 SetZero()
		{
			return Set(0, 0, 0, 0);
		}

		public Matrix2x2 Inverse()
		{
			float a = M00, b = M10, c = M01, d = M11;
			float det = a * d - b * c;
			if (det != 0.0f)
			{
				det = 1.0f / det;
			}
			M00 = det * d;
			M10 = -det * b;
			M01 = -det * c;
			M11 = det * a;
			return this;
		}

		public Vector2f Solve(Vector2f b)
		{
			float a11 = M00, a12 = M10, a21 = M01, a22 = M11;
			float det = a11 * a22 - a12 * a21;
			if (det != 0.0f)
			{
				det = 1.0f / det;
			}
			Vector2f x;
			x.X = det * (a22 * b.X - a12 * b.Y);
			x.Y = det * (a11 * b.Y - a21 * b.X);
			return x;
		}

		public static Vector2f operator *(Matrix2x2 A, Vector2f B)
		{
			return new Vector2f(A.M00 * B.X + A.M10 * B.Y, A.M01 * B.X + A.M11 * B.Y);
		}
	}
}