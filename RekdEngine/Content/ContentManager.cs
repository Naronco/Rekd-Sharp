using RekdEngine.Event;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Content
{
	public class ContentManager
	{
		public ContentManager()
		{
			GameEventListener.ResizeEvent += HandleDeviceLost;
			GameEventListener.DeviceResetEvent += HandleDeviceReset;
		}

		protected void HandleDeviceReset(Form Window, Device d)
		{
		}

		protected void HandleDeviceLost(Form Window, Size e)
		{
		}
	}
}