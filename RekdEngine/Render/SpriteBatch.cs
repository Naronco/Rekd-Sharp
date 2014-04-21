using RekdEngine.Core;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.Render
{
	public class SpriteBatch
	{
		private Device Device;

		public SpriteBatch(Device d)
		{
			Device = d;
		}

		public void Begin(Color clear)
		{
			Device.BeginScene();
			Device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, clear.AsSharpDXBGRA(), 1.0f, 0);
		}

		public void End()
		{
			Device.EndScene();
		}
	}
}