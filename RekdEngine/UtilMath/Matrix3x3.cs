using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Matrix3x3
	{
		public float M00, M01, M02;
		public float M10, M11, M12;
		public float M20, M21, M22;

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
					else if (y == 2)
					{
						return M02;
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
					else if (y == 2)
					{
						return M12;
					}
				}
				else if (x == 2)
				{
					if (y == 0)
					{
						return M20;
					}
					else if (y == 1)
					{
						return M21;
					}
					else if (y == 2)
					{
						return M22;
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
					else if (y == 2)
					{
						M02 = value;
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
					else if (y == 2)
					{
						M12 = value;
					}
				}
				else if (x == 2)
				{
					if (y == 0)
					{
						M20 = value;
					}
					else if (y == 1)
					{
						M21 = value;
					}
					else if (y == 2)
					{
						M22 = value;
					}
				}
			}
		}

		public Matrix3x3(float M00 = 1, float M01 = 0, float M02 = 0,
						 float M10 = 0, float M11 = 1, float M12 = 0,
						 float M20 = 0, float M21 = 0, float M22 = 1)
		{
			this.M00 = M00;
			this.M01 = M01;
			this.M02 = M02;
			this.M10 = M10;
			this.M11 = M11;
			this.M12 = M12;
			this.M20 = M20;
			this.M21 = M21;
			this.M22 = M22;
		}

		public Matrix3x3(Matrix3x3 Other)
		{
			M00 = Other.M00;
			M01 = Other.M01;
			M02 = Other.M02;
			M10 = Other.M10;
			M11 = Other.M11;
			M12 = Other.M12;
			M20 = Other.M20;
			M21 = Other.M21;
			M22 = Other.M22;
		}

		public Matrix3x3 SetIdentity()
		{
			return Set(1, 0, 0, 0, 1, 0, 0, 0, 1);
		}

		public Matrix3x3 Set(float M00, float M01, float M02,
							 float M10, float M11, float M12,
							 float M20, float M21, float M22)
		{
			this.M00 = M00;
			this.M01 = M01;
			this.M02 = M02;
			this.M10 = M10;
			this.M11 = M11;
			this.M12 = M12;
			this.M20 = M20;
			this.M21 = M21;
			this.M22 = M22;
			return this;
		}

		public Matrix3x3 Set(Matrix3x3 Other)
		{
			M00 = Other.M00;
			M01 = Other.M01;
			M02 = Other.M02;
			M10 = Other.M10;
			M11 = Other.M11;
			M12 = Other.M12;
			M20 = Other.M20;
			M21 = Other.M21;
			M22 = Other.M22;
			return this;
		}

		public static Matrix3x3 operator *(Matrix3x3 a, Matrix3x3 b)
		{
			Matrix3x3 r = new Matrix3x3();
			for (int y = 0; y < 3; y++)
				for (int x = 0; x < 3; x++)
					r[x, y] = (a[x, 0] * b[0, y]) + (a[x, 1] * b[1, y]) + (a[x, 2] * b[2, y]);
			return r;
		}

		public Vector2f Transform(Vector2f vec)
		{
			float rot = (float)Math.Atan(M10 / M11);
			float sx = (float)Math.Sqrt(M00 * M00 + M01 * M01);
			float sy = (float)Math.Sqrt(M10 * M10 + M11 * M11);
			return new Vector2f((float)(M02 + sx * (Math.Cos(rot) * vec.X - Math.Sin(rot) * vec.Y)), (float)(M12 + sy * (Math.Sin(rot) * vec.X - Math.Cos(rot) * vec.Y)));
		}

		public Matrix3x3 Rotate(float rad)
		{
			float s = (float)Math.Sin(rad);
			float c = (float)Math.Cos(rad);
			return (this *= new Matrix3x3(c, -s, 0, s, c, 0, 0, 0, 1));
		}

		public Matrix3x3 Scale(float x, float y)
		{
			return (this *= new Matrix3x3(x, 0, 0, 0, y, 0, 0, 0, 1));
		}

		public Matrix3x3 Translate(float x, float y)
		{
			return (this *= new Matrix3x3(1, 0, x, 0, 1, y, 0, 0, 1));
		}

		public Matrix3x3 Transpose()
		{
			return Set(M00, M10, M20, M01, M11, M21, M02, M12, M22);
		}

		public float GetRotation()
		{
			return (float)Math.Atan(M10 / M11);
		}

		public Vector2f GetScale()
		{
			return new Vector2f((float)Math.Sqrt(M00 * M00 + M01 * M01), (float)Math.Sqrt(M10 * M10 + M11 * M11));
		}

		public Vector2f GetTranslation()
		{
			return new Vector2f(M02, M12);
		}
	}
}