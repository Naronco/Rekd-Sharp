﻿using RekdEngine.UtilMath;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eff = SharpDX.Direct3D9.Effect;

namespace RekdEngine.Content
{
	public class Effect : NonManagedRessource
	{
		private Eff handle;

		public Effect(Device d, string File)
		{
			handle = Eff.FromFile(d, File, ShaderFlags.None);
		}

		public Effect(Device d, string content, ShaderFlags s)
		{
			handle = Eff.FromString(d, content, s);
		}

		public void Reset()
		{
			handle.OnResetDevice();
		}

		public void Lost()
		{
			handle.OnLostDevice();
		}

		public void Dispose()
		{
			handle.Dispose();
		}

		public void Begin()
		{
			handle.Begin();
		}

		public void BeginPass(int pass)
		{
			handle.BeginPass(pass);
		}

		public void EndPass()
		{
			handle.EndPass();
		}

		public void End()
		{
			handle.End();
		}

		public void SetValue(string name, bool v)
		{
			handle.SetValue(name, v);
		}

		public void SetValue(string name, float v)
		{
			handle.SetValue(name, v);
		}

		public void SetValue(string name, int v)
		{
			handle.SetValue(name, v);
		}

		public void SetValue(string name, Matrix v)
		{
			handle.SetValue(name, v);
		}

		public void SetValue(string name, Vector4 v)
		{
			handle.SetValue(name, v);
		}

		public void NativeSetTexture(string name, BaseTexture tex)
		{
			handle.SetTexture(name, tex);
		}

		public void SetTexture(string name, Texture2D tex)
		{
			handle.SetTexture(name, tex.handle);
		}

		public void SetMatrix(string name, Matrix4x4 m)
		{
			handle.SetValue(name, m.AsSharpDX());
		}

		public void SetMatrix(string name, Matrix m)
		{
			handle.SetValue(name, m);
		}

		public void SetColor(string name, Core.Color c)
		{
			handle.SetValue(name, c.AsSharpDX4());
		}

		public void SetVector(string name, Vector2f v)
		{
			handle.SetValue(name, new Vector2(v.X, v.Y));
		}

		public void SetVector(string name, Vector3f v)
		{
			handle.SetValue(name, new Vector3(v.X, v.Y, v.Z));
		}

		public void SetVector(string name, Vector4f v)
		{
			handle.SetValue(name, new Vector4(v.X, v.Y, v.Z, v.W));
		}

		/*
		public Matrix4x4 this[string s]
		{
			get
			{
				return new Matrix4x4(handle.GetValue<Matrix>(s));
			}

			set
			{
				handle.SetValue<Matrix>(s, value.AsSharpDX());
			}
		}

		public Matrix3x3 this[string s]
		{
			get
			{
				return new Matrix3x3(handle.GetValue<Matrix3x2>(s));
			}

			set
			{
				handle.SetValue<Matrix3x2>(s, value.AsSharpDX());
			}
		}

		public Texture2D this[string s]
		{
			get
			{
				return new Texture2D((Texture)handle.GetTexture(s));
			}

			set
			{
				handle.SetTexture(s, value.handle);
			}
		}

		public float this[string s]
		{
			get
			{
				return handle.GetValue<float>(s);
			}

			set
			{
				handle.SetValue<float>(s, value);
			}
		}

		public string this[string s]
		{
			get
			{
				return handle.GetString(s);
			}

			set
			{
				handle.SetString(s, value);
			}
		}*/
	}
}