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
	public delegate void ClickEvent(Form Window, MouseEventArgs e);

	public delegate void KeyDownEvent(Form Window, KeyEventArgs e);

	public delegate void KeyUpEvent(Form Window, KeyEventArgs e);

	public delegate void ResizeEvent(Form Window, Size e);

	public delegate void CloseEvent(Form Window, FormClosingEventArgs e);

	public delegate void DeviceResetEvent(Form Window, Device d);
}