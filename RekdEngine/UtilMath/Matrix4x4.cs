using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.UtilMath
{
	public struct Matrix4x4
	{
		public float M00, M01, M02, M03;
		public float M10, M11, M12, M13;
		public float M20, M21, M22, M23;
		public float M30, M31, M32, M33;

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
					else if (y == 3)
					{
						return M03;
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
					else if (y == 3)
					{
						return M13;
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
					else if (y == 3)
					{
						return M23;
					}
				}
				else if (x == 3)
				{
					if (y == 0)
					{
						return M30;
					}
					else if (y == 1)
					{
						return M31;
					}
					else if (y == 2)
					{
						return M32;
					}
					else if (y == 3)
					{
						return M33;
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
					else if (y == 3)
					{
						M03 = value;
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
					else if (y == 3)
					{
						M13 = value;
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
					else if (y == 3)
					{
						M23 = value;
					}
				}
				else if (x == 3)
				{
					if (y == 0)
					{
						M30 = value;
					}
					else if (y == 1)
					{
						M31 = value;
					}
					else if (y == 2)
					{
						M32 = value;
					}
					else if (y == 3)
					{
						M33 = value;
					}
				}
			}
		}

		public Matrix4x4()
		{
			M00 = 1;
			M01 = 0;
			M02 = 0;
			M03 = 0;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M13 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 1;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;
		}

		public Matrix4x4(float M00, float M01, float M02, float M03,
						float M10, float M11, float M12, float M13,
						float M20, float M21, float M22, float M23,
						float M30, float M31, float M32, float M33)
		{
			this.M00 = M00;
			this.M01 = M01;
			this.M02 = M02;
			this.M03 = M03;
			this.M10 = M10;
			this.M11 = M11;
			this.M12 = M12;
			this.M13 = M13;
			this.M20 = M20;
			this.M21 = M21;
			this.M22 = M22;
			this.M23 = M23;
			this.M30 = M30;
			this.M31 = M31;
			this.M32 = M32;
			this.M33 = M33;
		}

		public Matrix4x4(Matrix4x4 Other)
		{
			M00 = Other.M00;
			M01 = Other.M01;
			M02 = Other.M02;
			M03 = Other.M03;
			M10 = Other.M10;
			M11 = Other.M11;
			M12 = Other.M12;
			M13 = Other.M13;
			M20 = Other.M20;
			M21 = Other.M21;
			M22 = Other.M22;
			M23 = Other.M23;
			M30 = Other.M30;
			M31 = Other.M31;
			M32 = Other.M32;
			M33 = Other.M33;
		}

		public Matrix4x4 Set(float M00, float M01, float M02, float M03,
						float M10, float M11, float M12, float M13,
						float M20, float M21, float M22, float M23,
						float M30, float M31, float M32, float M33)
		{
			this.M00 = M00;
			this.M01 = M01;
			this.M02 = M02;
			this.M03 = M03;
			this.M10 = M10;
			this.M11 = M11;
			this.M12 = M12;
			this.M13 = M13;
			this.M20 = M20;
			this.M21 = M21;
			this.M22 = M22;
			this.M23 = M23;
			this.M30 = M30;
			this.M31 = M31;
			this.M32 = M32;
			this.M33 = M33;
			return this;
		}

		public Matrix4x4 Set(Matrix4x4 Other)
		{
			M00 = Other.M00;
			M01 = Other.M01;
			M02 = Other.M02;
			M03 = Other.M03;
			M10 = Other.M10;
			M11 = Other.M11;
			M12 = Other.M12;
			M13 = Other.M13;
			M20 = Other.M20;
			M21 = Other.M21;
			M22 = Other.M22;
			M23 = Other.M23;
			M30 = Other.M30;
			M31 = Other.M31;
			M32 = Other.M32;
			M33 = Other.M33;
			return this;
		}

		public Matrix4x4 SetIdentity()
		{
			return Set(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
		}

		public static Matrix4x4 operator *(Matrix4x4 a, Matrix4x4 b)
		{
			Matrix4x4 r = new Matrix4x4();
			for (int y = 0; y < 4; y++)
				for (int x = 0; x < 4; x++)
				{
					r[x, y] = (a[x, 0] * b[0, y]) + (a[x, 1] * b[1, y]) + (a[x, 2] * b[2, y]) + (a[x, 3] * b[3, y]);
				}
			return r;
		}

		public Matrix4x4 Translate(float x, float y, float z)
		{
			return (this *= new Matrix4x4(1, 0, 0, x, 0, 1, 0, y, 0, 0, 1, z, 0, 0, 0, 1));
		}

		public Matrix4x4 RotateX(float angle)
		{
			float s = (float)Math.Sin(angle);
			float c = (float)Math.Cos(angle);
			return (this *= new Matrix4x4(1, 0, 0, 0, 0, c, -s, 0, 0, s, c, 0, 0, 0, 0, 1));
		}

		public Matrix4x4 RotateY(float angle)
		{
			float s = (float)Math.Sin(angle);
			float c = (float)Math.Cos(angle);
			return (this *= new Matrix4x4(c, 0, s, 0, 0, 1, 0, 0, -s, 0, c, 0, 0, 0, 0, 1));
		}

		public Matrix4x4 RotateZ(float angle)
		{
			float s = (float)Math.Sin(angle);
			float c = (float)Math.Cos(angle);
			return (this *= new Matrix4x4(c, -s, 0, 0, s, c, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1));
		}

		public Matrix4x4 Scale(float x, float y, float z)
		{
			return (this *= new Matrix4x4(x, 0, 0, 0, 0, y, 0, 0, 0, 0, z, 0, 0, 0, 0, 1));
		}

		public Matrix4x4 Transpose()
		{
			return Set(M00, M10, M20, M30, M01, M11, M21, M31, M02, M12, M22, M32, M03, M13, M23, M33);
		}
	}
}