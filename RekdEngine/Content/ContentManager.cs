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
		/// <summary>
		/// The Directory where all data is stored. Doesn't need to end with a slash. Will always return with a slash.
		/// </summary>
		public string ContentDirectory { get { return cdir; } set { cdir = value.EndsWith("/") ? value : (value + "/"); } }

		private string cdir = "Content/";

		protected Device device;

		/// <summary>
		/// All ressources to Resize and Dispose
		/// </summary>
		protected List<NonManagedRessource> resources;

		/// <summary>
		/// All ressources to Dispose
		/// </summary>
		protected List<IDisposable> disposables;

		/// <summary>
		/// Creates a new ContentManager handle with Content/ as ContentDirectory
		/// </summary>
		public ContentManager(Device device)
		{
			this.device = device;
			GameEventListener.ResizeEvent += HandleDeviceLost;
			GameEventListener.DeviceResetEvent += HandleDeviceReset;
			resources = new List<NonManagedRessource>();
			disposables = new List<IDisposable>();
		}

		/// <summary>
		/// Handles the Device Reset
		/// </summary>
		/// <param name="Window">Not Used</param>
		/// <param name="d">Not Used</param>
		protected void HandleDeviceReset(ContainerControl Window, Device d)
		{
			foreach (NonManagedRessource r in resources)
				r.Reset();
		}

		/// <summary>
		/// Handles the Device Lost
		/// </summary>
		/// <param name="Window">Not Used</param>
		/// <param name="d">Not Used</param>
		protected void HandleDeviceLost(ContainerControl Window, Size e)
		{
			foreach (NonManagedRessource r in resources)
				r.Lost();
		}

		/// <summary>
		/// Loads a Resource from a File. Manages all Resources
		/// </summary>
		/// <typeparam name="T">Resource type</typeparam>
		/// <param name="path">Filename + Fileextension</param>
		/// <returns>Loaded Resource</returns>
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

		/// <summary>
		/// Loads A Resource from a String. Manages all Resources
		/// </summary>
		/// <typeparam name="T">Resource type</typeparam>
		/// <param name="path">Filename + Fileextension</param>
		/// <returns>Loaded Resource</returns>
		public T LoadString<T>(string content)
		{
			if (typeof(T) == typeof(Texture2D))
			{
				throw new NotSupportedException("Cannot load an image from a string");
			}
			else if (typeof(T) == typeof(Effect))
			{
				Effect eff = new Effect(device, content, ShaderFlags.None);
				resources.Add(eff);
				return (T)(object)eff;
			}
			throw new NotSupportedException("Cannot load a " + typeof(T).Name);
		}

		/// <summary>
		/// Deletes all Resources
		/// </summary>
		public void Dispose()
		{
			foreach (NonManagedRessource r in resources)
				r.Dispose();
			foreach (IDisposable r in disposables)
				r.Dispose();
		}
	}
}