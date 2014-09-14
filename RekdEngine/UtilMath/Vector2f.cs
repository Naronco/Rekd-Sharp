using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = System.Math;

namespace RekdEngine.UtilMath
{
	public struct Vector2f
	{
		public float X, Y;

		public Vector2f(float X = 0, float Y = 0)
		{
			this.X = X;
			this.Y = Y;
		}

		public Vector2f(Vector2f other)
		{
			X = other.X;
			Y = other.Y;
		}

		public Vector2f Clear()
		{
			X = Y = 0;
			return this;
		}

		public Vector2f Set(float X, float Y)
		{
			this.X = X;
			this.Y = Y;
			return this;
		}

		public Vector2f Set(Vector2f other)
		{
			X = other.X;
			Y = other.Y;
			return this;
		}

		public override int GetHashCode()
		{
			return X.GetHashCode() + Y.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return obj is Vector2f && this == (Vector2f)obj;
		}

		public static bool operator ==(Vector2f A, Vector2f B)
		{
			return A.X == B.X && A.Y == B.Y;
		}

		public static bool operator !=(Vector2f A, Vector2f B)
		{
			return A.X != B.X || A.Y != B.Y;
		}

		public static Vector2f operator -(Vector2f v)
		{
			return new Vector2f(-v.X, -v.Y);
		}

		public static Vector2f operator +(Vector2f A, Vector2f B)
		{
			return new Vector2f(A.X + B.X, A.Y + B.Y);
		}

		public static Vector2f operator -(Vector2f A, Vector2f B)
		{
			return new Vector2f(A.X - B.X, A.Y - B.Y);
		}

		public static Vector2f operator *(Vector2f v, float scalar)
		{
			return new Vector2f(v.X * scalar, v.Y * scalar);
		}

		public static Vector2f operator /(Vector2f v, float scalar)
		{
			return new Vector2f(v.X / scalar, v.Y / scalar);
		}

		public static Vector2f operator *(float scalar, Vector2f v)
		{
			return new Vector2f(v.X * scalar, v.Y * scalar);
		}

		public float GetSquaredLength()
		{
			return X * X + Y * Y;
		}

		public float GetLength()
		{
			return (float)M.Sqrt(X * X + Y * Y);
		}

		public static float GetSquaredDistance(Vector2f A, Vector2f B)
		{
			float xd = A.X - B.X;
			float yd = A.Y - B.Y;
			return xd * xd + yd * yd;
		}

		public float GetSquaredDistance(Vector2f other)
		{
			return GetSquaredDistance(this, other);
		}

		public static float GetDistance(Vector2f A, Vector2f B)
		{
			float xd = A.X - B.X;
			float yd = A.Y - B.Y;
			return (float)M.Sqrt(xd * xd + yd * yd);
		}

		public float GetDistance(Vector2f other)
		{
			return GetDistance(this, other);
		}

		public Vector2f Normalize()
		{
			return this * (1 / GetLength());
		}

		public float Dot(Vector2f v)
		{
			return X * v.X + Y * v.Y;
		}

		public float Cross(Vector2f v)
		{
			return X * v.X - Y * v.Y;
		}

		public Vector2f SetZero()
		{
			X = 0;
			Y = 0;
			return this;
		}
	}
}