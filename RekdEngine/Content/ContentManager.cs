using RekdEngine.Event;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Content
{
	public class ContentManager : IDisposable
	{
		public string ContentDirectory { get { return cdir; } set { cdir = value.EndsWith("/") ? value : (value + "/"); } }

		private string cdir = "Content/";

		protected Device device;

		protected List<NonManagedRessource> resources;
		protected List<IDisposable> disposables;

		public ContentManager(Device device)
		{
			this.device = device;
			GameEventListener.ResizeEvent += HandleDeviceLost;
			GameEventListener.DeviceResetEvent += HandleDeviceReset;
			resources = new List<NonManagedRessource>();
			disposables = new List<IDisposable>();
		}

		protected void HandleDeviceReset(Form Window, Device d)
		{
			foreach (NonManagedRessource r in resources)
				r.Reset();
		}

		protected void HandleDeviceLost(Form Window, Size e)
		{
			foreach (NonManagedRessource r in resources)
				r.Lost();
		}

		public T Load<T>(string path)
		{
			if (!File.Exists(cdir + path))
				throw new FileNotFoundException(cdir + path);
			if (typeof(T) == typeof(Texture2D))
			{
				Texture2D tex = new Texture2D(device, cdir + path);
				resources.Add(tex);
				return (T)(object)tex;
			}
			else if (typeof(T) == typeof(Effect))
			{
				Effect eff = new Effect(device, cdir + path);
				resources.Add(eff);
				return (T)(object)eff;
			}
			throw new NotSupportedException("Cannot load a " + typeof(T).Name);
		}

		public void Dispose()
		{
			foreach (NonManagedRessource r in resources)
				r.Dispose();
			foreach (IDisposable r in disposables)
				r.Dispose();
		}
	}
}