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
	}
}