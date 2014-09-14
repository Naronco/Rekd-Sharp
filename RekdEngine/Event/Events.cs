using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Event
{
	public delegate void ClickEvent(ContainerControl Window, MouseEventArgs e);

	public delegate void KeyDownEvent(ContainerControl Window, KeyEventArgs e);

	public delegate void KeyUpEvent(ContainerControl Window, KeyEventArgs e);

	public delegate void ResizeEvent(ContainerControl Window, Size e);

	public delegate void CloseEvent(ContainerControl Window, FormClosingEventArgs e);

	public delegate void DeviceResetEvent(ContainerControl Window, Device d);
}