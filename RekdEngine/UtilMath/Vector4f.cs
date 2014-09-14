using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = System.Math;

namespace RekdEngine.UtilMath
{
	public struct Vector4f
	{
		public float X, Y, Z, W;

		public Vector4f(float X = 0, float Y = 0, float Z = 0, float W = 0)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.W = W;
		}

		public Vector4f(Vector4f other)
		{
			X = other.X;
			Y = other.Y;
			Z = other.Z;
			W = other.W;
		}

		public Vector4f Clear()
		{
			X = Y = Z = W = 0;
			return this;
		}

		public Vector4f Set(float X, float Y, float Z, float W)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.W = W;
			return this;
		}

		public Vector4f Set(Vector4f other)
		{
			X = other.X;
			Y = other.Y;
			Z = other.Z;
			W = other.W;
			return this;
		}

		public override int GetHashCode()
		{
			return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + W.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return obj is Vector4f && this == (Vector4f)obj;
		}

		public static bool operator ==(Vector4f A, Vector4f B)
		{
			return A.X == B.X && A.Y == B.Y && A.Z == B.Z && A.W == B.W;
		}

		public static bool operator !=(Vector4f A, Vector4f B)
		{
			return A.X != B.X || A.Y != B.Y || A.Z != B.Z || A.W != B.W;
		}

		public static Vector4f operator -(Vector4f v)
		{
			return new Vector4f(-v.X, -v.Y, -v.Z, v.W);
		}

		public static Vector4f operator +(Vector4f A, Vector4f B)
		{
			return new Vector4f(A.X + B.X, A.Y + B.Y, A.Z + B.Z, A.W);
		}

		public static Vector4f operator -(Vector4f A, Vector4f B)
		{
			return new Vector4f(A.X - B.X, A.Y - B.Y, A.Z - B.Z, A.W);
		}

		public static Vector4f operator *(Vector4f v, float scalar)
		{
			return new Vector4f(v.X * scalar, v.Y * scalar, v.Z * scalar, v.W);
		}

		public static Vector4f operator /(Vector4f v, float scalar)
		{
			return new Vector4f(v.X / scalar, v.Y / scalar, v.Z / scalar, v.W);
		}

		public static Vector4f operator *(float scalar, Vector4f v)
		{
			return new Vector4f(v.X * scalar, v.Y * scalar, v.Z * scalar, v.W);
		}

		public float GetSquaredLength()
		{
			return X * X + Y * Y + Z * Z + W * W;
		}

		public float GetLength()
		{
			return (float)M.Sqrt(X * X + Y * Y + Z * Z + W * W);
		}

		public static float GetSquaredDistance(Vector4f A, Vector4f B)
		{
			float xd = A.X - B.X;
			float yd = A.Y - B.Y;
			float zd = A.Z - B.Z;
			return xd * xd + yd * yd + zd * zd;
		}

		public float GetSquaredDistance(Vector4f other)
		{
			return GetSquaredDistance(this, other);
		}

		public static float GetDistance(Vector4f A, Vector4f B)
		{
			float xd = A.X - B.X;
			float yd = A.Y - B.Y;
			float zd = A.Z - B.Z;
			float wd = A.W - B.W;
			return (float)M.Sqrt(xd * xd + yd * yd + zd * zd + wd * wd);
		}

		public float GetDistance(Vector4f other)
		{
			return GetDistance(this, other);
		}

		public Vector4f Normalize()
		{
			return this * (1 / GetLength());
		}

		public float Dot(Vector4f v)
		{
			return X * v.X + Y * v.Y + Z * v.Z + W * v.W;
		}

		public Vector4f Cross(Vector4f v)
		{
			return new Vector4f(Y * v.Z - Z * v.Y, Z * v.X - X * v.Z, X * v.Y - Y * v.X, W);
		}
	}
}