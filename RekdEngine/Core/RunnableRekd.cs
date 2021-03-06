﻿using RekdEngine.Debug;
using RekdEngine.Event;
using RekdEngine.UtilMath;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Core
{
	public class RunnableRekd : IDisposable
	{
		protected RenderForm Window;
		protected Device Device;
		protected Direct3D Direct3D;

		public int PreWindowWidth;
		public int PreWindowHeight;
		public string PreWindowTitle;
		public Action MainLoop;

		public FormWindowState WindowState { get; protected set; }

		public bool Closed { get; protected set; }

		public RunnableRekd()
		{
			MainLoop = () =>
			{
				UpdateWindow();
				Clear(new Color(43, 78, 124));
				BeginScene();
				EndScene();
			};
		}

		public void InitDX()
		{
			Direct3D = new Direct3D();
			Device = new Device(Direct3D, 0, DeviceType.Hardware, Window.Handle, CreateFlags.HardwareVertexProcessing, new PresentParameters(Window.ClientSize.Width, Window.ClientSize.Height)
			{
				MultiSampleType = MultisampleType.EightSamples
			});
			Window.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - Window.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Window.Height / 2);
			ConfigDX();
		}

		public void ConfigDX()
		{
			Device.SetTransform(TransformState.Projection, Matrix.OrthoLH(Window.ClientSize.Width, Window.ClientSize.Height, -1, 1));
			Device.SetRenderState(RenderState.AlphaBlendEnable, true);
			Device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
			Device.SetRenderState(RenderState.DestinationBlend, Blend.InverseSourceAlpha);
		}

		public RenderForm CreateWindowHandle(string title, int width, int height)
		{
			RenderForm handle = new RenderForm(title)
			{
				ClientSize = new Size(width, height),
				MinimumSize = new Size(0, 0)
			};
			handle.Hide();

			WindowState = handle.WindowState;

			handle.MouseClick += (s, e) => { GameEventListener.RunClickEvent(handle, e); };
			handle.KeyDown += (s, e) => { GameEventListener.RunKeyDownEvent(handle, e); };
			handle.KeyUp += (s, e) => { GameEventListener.RunKeyUpEvent(handle, e); };
			handle.UserResized += (s, e) =>
			{
				GameEventListener.RunResizeEvent(handle, new Size(handle.Width, handle.Height));
				Device.Reset(new PresentParameters(Window.ClientSize.Width, Math.Max(1, Window.ClientSize.Height))
				{
					MultiSampleType = MultisampleType.EightSamples
				});
				GameEventListener.RunDeviceResetEvent(handle, Device);
				ConfigDX();
			};
			handle.FormClosing += (s, e) => { GameEventListener.RunPreCloseEvent(handle, e); };
			handle.FormClosed += (s, e) => { Closed = true; };

			return handle;
		}

		public void CreateWindow()
		{
			Window = CreateWindowHandle(PreWindowTitle, PreWindowWidth, PreWindowHeight);
			Closed = false;
		}

		public void InitUtils()
		{
		}

		public void LoadAddons()
		{
		}

		public void PrepareRender()
		{
		}

		public void ShowWindow()
		{
			Window.Show();
		}

		public void UpdateWindow()
		{
		}

		public void Clear(Color c)
		{
			Device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, c.AsSharpDXBGRA(), 1.0f, 0);
		}

		public TimeSpan CalculateDelta()
		{
			return TimeSpan.Zero;
		}

		public void DoFormLoop(Form f, Func<bool> isOpen, Action doStuff)
		{
			RenderLoop.Run(f, () =>
			{
				if (!isOpen()) return;
				Clear(new Color(43, 78, 124));
				doStuff();
			});
		}

		public void DoMainLoop()
		{
			DebugWrite.Log("Started Game using Rekd#");
			Stopwatch sw = Stopwatch.StartNew();
			CreateWindow();
			InitDX();
			InitVars();
			InitUtils();
			LoadAddons();
			BeforeLoop();
			PrepareRender();
			sw.Stop();
			DebugWrite.Log("Initialized in " + sw.Elapsed.ToString());
			DoFormLoop(Window, () => { return !Closed; }, MainLoop);
			DebugWrite.Log("Stopped Game");
		}

		public virtual void BeforeLoop()
		{
		}

		public virtual void InitVars()
		{
		}

		public void BeginScene()
		{
			Device.BeginScene();
		}

		public void EndScene()
		{
			Device.EndScene();
		}

		public void Present()
		{
			Device.Present();
		}

		public void Dispose()
		{
			Device.Dispose();
			Direct3D.Dispose();
			Window.Dispose();
		}
	}
}