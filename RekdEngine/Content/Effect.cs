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

		public void SetTexture(string name, Texture2D tex)
		{
			handle.SetTexture(name, tex.handle);
		}
	}
}