using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = System.Math;

namespace RekdEngine.UtilMath
{
	public struct Vector3f
	{
		public float X, Y, Z;

		public Vector3f(float X = 0, float Y = 0, float Z = 0)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		public Vector3f(Vector3f other)
		{
			X = other.X;
			Y = other.Y;
			Z = other.Z;
		}

		public Vector3f Clear()
		{
			X = Y = Z = 0;
			return this;
		}

		public Vector3f Set(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			return this;
		}

		public Vector3f Set(Vector3f other)
		{
			X = other.X;
			Y = other.Y;
			Z = other.Z;
			return this;
		}

		public static bool operator ==(Vector3f A, Vector3f B)
		{
			return A.X == B.X && A.Y == B.Y && A.Z == B.Z;
		}

		public static bool operator !=(Vector3f A, Vector3f B)
		{
			return A.X != B.X || A.Y != B.Y || A.Z != B.Z;
		}

		public static Vector3f operator -(Vector3f v)
		{
			return new Vector3f(-v.X, -v.Y, -v.Z);
		}

		public static Vector3f operator +(Vector3f A, Vector3f B)
		{
			return new Vector3f(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
		}

		public static Vector3f operator -(Vector3f A, Vector3f B)
		{
			return new Vector3f(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
		}

		public static Vector3f operator *(Vector3f v, float scalar)
		{
			return new Vector3f(v.X * scalar, v.Y * scalar, v.Z * scalar);
		}

		public static Vector3f operator /(Vector3f v, float scalar)
		{
			return new Vector3f(v.X / scalar, v.Y / scalar, v.Z / scalar);
		}

		public static Vector3f operator *(float scalar, Vector3f v)
		{
			return new Vector3f(v.X * scalar, v.Y * scalar, v.Z * scalar);
		}

		public float GetSquaredLength()
		{
			return X * X + Y * Y + Z * Z;
		}

		public float GetLength()
		{
			return (float)M.Sqrt(X * X + Y * Y + Z * Z);
		}

		public static float GetSquaredDistance(Vector3f A, Vector3f B)
		{
			float xd = A.X - B.X;
			float yd = A.Y - B.Y;
			float zd = A.Z - B.Z;
			return xd * xd + yd * yd + zd * zd;
		}

		public float GetSquaredDistance(Vector3f other)
		{
			return GetSquaredDistance(this, other);
		}

		public static float GetDistance(Vector3f A, Vector3f B)
		{
			float xd = A.X - B.X;
			float yd = A.Y - B.Y;
			float zd = A.Z - B.Z;
			return (float)M.Sqrt(xd * xd + yd * yd + zd * zd);
		}

		public float GetDistance(Vector3f other)
		{
			return GetDistance(this, other);
		}

		public Vector3f Normalize()
		{
			return this * (1 / GetLength());
		}

		public float Dot(Vector3f v)
		{
			return X * v.X + Y * v.Y + Z * v.Z;
		}

		public Vector3f Cross(Vector3f v)
		{
			return new Vector3f(Y * v.Z - Z * v.Y, Z * v.X - X * v.Z, X * v.Y - Y * v.X);
		}
	}
}