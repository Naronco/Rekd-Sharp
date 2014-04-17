using RekdEngine.Event;
using SlimDX.Direct2D;
using SlimDX.Windows;
using System;
using System.Collections.Generic;
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
		private WindowRenderTarget RenderTarget;
		private Factory factory;
		private Form handle;
		private RenderTarget CurrentRenderTarget;

		public int PreWindowWidth;
		public int PreWindowHeight;
		public string PreWindowTitle;
		public Action MainLoop;

		public FormWindowState WindowState { public get; protected set; }

		public bool Closed { public get; protected set; }

		public RunnableRekd()
		{
			MainLoop = () =>
			{
				UpdateWindow();
				BindRendertarget();
				PresentRendertarget();
			};
		}

		public void InitDX()
		{
			RenderTarget = new WindowRenderTarget(factory, new WindowRenderTargetProperties
			{
				Handle = handle.Handle,
				PixelSize = new Size(PreWindowWidth, PreWindowHeight)
			});
		}

		public Form CreateWindowHandle(string title, int width, int height)
		{
			Form handle = new RenderForm(title)
			{
				ClientSize = new Size(width, height)
			};
			handle.Hide();
			WindowState = handle.WindowState;

			handle.MouseClick += (s, e) => { GameEventListener.RunClickEvent(handle, e); };
			handle.KeyDown += (s, e) => { GameEventListener.RunKeyDownEvent(handle, e); };
			handle.KeyUp += (s, e) => { GameEventListener.RunKeyUpEvent(handle, e); };
			handle.ResizeEnd += (s, e) => { GameEventListener.RunResizeEvent(handle, new Size(handle.Width, handle.Height)); };
			handle.FormClosing += (s, e) => { GameEventListener.RunPreCloseEvent(handle, e); };
			handle.FormClosed += (s, e) => { Closed = true; };

			return handle;
		}

		public void CreateWindow()
		{
			handle = CreateWindowHandle(PreWindowTitle, PreWindowWidth, PreWindowHeight);
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
			handle.Show();
		}

		public void UpdateWindow()
		{
		}

		public void BindRendertarget()
		{
			CurrentRenderTarget = RenderTarget;
			CurrentRenderTarget.BeginDraw();
		}

		public void Clear(Color c)
		{
			CurrentRenderTarget.Clear(c.AsSlimDX4());
		}

		public TimeSpan CalculateDelta()
		{
			return TimeSpan.Zero;
		}

		public void DoFormLoop(Form f, Func<bool> isOpen, Action doStuff)
		{
			MessagePump.Run(f, () =>
			{
				if (!isOpen()) return;
				doStuff();
			});
		}

		public void DoMainLoop()
		{
			CreateWindow();
			InitDX();
			InitVars();
			InitUtils();
			LoadAddons();
			BeforeLoop();
			PrepareRender();
			DoFormLoop(handle, () => { return Closed; }, MainLoop);
		}

		public virtual void BeforeLoop();

		public virtual void InitVars();

		public void PresentRendertarget()
		{
			CurrentRenderTarget.EndDraw();
		}

		public void Dispose()
		{
		}
	}
}