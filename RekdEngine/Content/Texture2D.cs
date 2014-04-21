using RekdEngine.Core;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Content
{
	public class Texture2D
	{
		internal Texture handle;

		public int Width, Height;

		private Device Device;

		public Texture2D()
		{
			Width = 0;
			Height = 0;
		}

		public Texture2D(Device d, int width, int height)
		{
			handle = new Texture(d, width, height, 1, Usage.None, Format.A8R8G8B8, Pool.Managed);
			Width = width;
			Height = height;
			Device = d;
		}

		public Texture2D(Device d, string file)
		{
			handle = Texture.FromFile(d, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), file), Usage.None, Pool.Managed);
			ImageInformation i = ImageInformation.FromFile(file);
			Width = i.Width;
			Height = i.Height;
			Device = d;
		}

		public void SetColors(Color[] c)
		{
			handle.Fill((coord, texel) =>
			{
				return c[(int)(coord.X + Width * coord.Y)].AsSharpDX4();
			});
		}

		public void Bind(int slot)
		{
			Device.SetTexture(slot, handle);
		}
	}
}