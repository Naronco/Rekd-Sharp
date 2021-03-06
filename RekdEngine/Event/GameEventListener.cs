﻿using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Event
{
	public class GameEventListener
	{
		public static event ClickEvent ClickEvent;

		public static event KeyDownEvent KeyDownEvent;

		public static event KeyUpEvent KeyUpEvent;

		public static event ResizeEvent ResizeEvent;

		public static event CloseEvent CloseEvent;

		public static event DeviceResetEvent DeviceResetEvent;

		public static void RunClickEvent(ContainerControl Window, MouseEventArgs e)
		{
			if (ClickEvent != null) ClickEvent(Window, e);
		}

		public static void RunKeyDownEvent(ContainerControl Window, KeyEventArgs e)
		{
			if (KeyDownEvent != null) KeyDownEvent(Window, e);
		}

		public static void RunKeyUpEvent(ContainerControl Window, KeyEventArgs e)
		{
			if (KeyUpEvent != null) KeyUpEvent(Window, e);
		}

		public static void RunResizeEvent(ContainerControl Window, Size e)
		{
			if (ResizeEvent != null) ResizeEvent(Window, e);
		}

		public static void RunDeviceResetEvent(ContainerControl Window, Device e)
		{
			if (DeviceResetEvent != null) DeviceResetEvent(Window, e);
		}

		public static void RunPreCloseEvent(ContainerControl Window, FormClosingEventArgs e)
		{
			if (CloseEvent != null) CloseEvent(Window, e);
		}
	}
}