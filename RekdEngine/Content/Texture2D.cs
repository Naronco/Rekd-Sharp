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
	public class Texture2D : NonManagedRessource
	{
		internal Texture handle;

		public int Width, Height;

		private Device device;

		private bool managed;

		private Usage usage;

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
			device = d;
			managed = true;
			usage = Usage.None;
		}

		public Texture2D(Device d, int width, int height, Usage u)
		{
			handle = new Texture(d, width, height, 1, u, Format.A8R8G8B8, Pool.Default);
			usage = u;
			Width = width;
			Height = height;
			device = d;
			managed = false;
		}

		public Texture2D(Device d, string file)
		{
			handle = Texture.FromFile(d, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), file), Usage.None, Pool.Managed);
			ImageInformation i = ImageInformation.FromFile(file);
			Width = i.Width;
			Height = i.Height;
			device = d;
			managed = true;
			usage = Usage.None;
		}

		public Texture2D(Texture t)
		{
			handle = t;
			managed = true;
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
			device.SetTexture(slot, handle);
		}

		public Surface GetSurfaceLevel(int level)
		{
			return handle.GetSurfaceLevel(level);
		}

		public void Reset()
		{
			if (!managed)
				handle = new Texture(device, Width, Height, 1, usage, Format.A8R8G8B8, Pool.Default);
		}

		public void Lost()
		{
			if (!managed)
				handle.Dispose();
		}

		public void Dispose()
		{
			handle.Dispose();
		}
	}
}