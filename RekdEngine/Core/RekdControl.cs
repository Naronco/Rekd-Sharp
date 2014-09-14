using RekdEngine.Debug;
using RekdEngine.Event;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Core
{
	/// <summary>
	/// WIP
	/// </summary>
	public class RekdControl : RenderControl
	{
		protected Device Device;
		protected Direct3D Direct3D;

		public Action MainLoop;

		public bool Closed { get; protected set; }

		public event EventHandler OnRender;

		public RekdControl()
		{
			MainLoop = () =>
			{
				Clear(new Color(27, 37, 45));
				BeginScene();
				if (OnRender != null)
					OnRender(this, EventArgs.Empty);
				EndScene();
				Present();
			};
		}

		public void InitDX()
		{
			Direct3D = new Direct3D();
			Device = new Device(Direct3D, 0, DeviceType.Hardware, Handle, CreateFlags.HardwareVertexProcessing, new PresentParameters(ClientSize.Width, ClientSize.Height)
			{
				MultiSampleType = MultisampleType.EightSamples
			});
			ConfigDX();
		}

		public void ConfigDX()
		{
			Device.SetTransform(TransformState.Projection, Matrix.OrthoLH(ClientSize.Width, ClientSize.Height, -1, 1));
			Device.SetRenderState(RenderState.AlphaBlendEnable, true);
			Device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
			Device.SetRenderState(RenderState.DestinationBlend, Blend.InverseSourceAlpha);
		}

		public RenderControl CreateControlHandle(int width, int height)
		{
			RenderControl handle = new RenderControl()
			{
				ClientSize = new Size(width, height),
				MinimumSize = new Size(0, 0)
			};

			handle.MouseClick += (s, e) => { GameEventListener.RunClickEvent(handle, e); };
			handle.KeyDown += (s, e) => { GameEventListener.RunKeyDownEvent(handle, e); };
			handle.KeyUp += (s, e) => { GameEventListener.RunKeyUpEvent(handle, e); };
			handle.Resize += (s, e) =>
			{
				GameEventListener.RunResizeEvent(handle, new Size(handle.Width, handle.Height));
				Device.Reset(new PresentParameters(ClientSize.Width, Math.Max(1, ClientSize.Height))
				{
					MultiSampleType = MultisampleType.EightSamples
				});
				GameEventListener.RunDeviceResetEvent(handle, Device);
				ConfigDX();
			};

			return handle;
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

		public void UpdateControl()
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

		public void DoMainLoop()
		{
			Task.Factory.StartNew(() =>
			{
				DebugWrite.Log("Started async Game using Rekd#Control");
				Stopwatch sw = Stopwatch.StartNew();
				InitDX();
				InitVars();
				InitUtils();
				LoadAddons();
				BeforeLoop();
				PrepareRender();
				sw.Stop();
				DebugWrite.Log("Initialized in " + sw.Elapsed.ToString());
				RenderLoop.Run(this, () =>
					{
						Clear(new Color(27, 37, 45));
						MainLoop();
					});
				DebugWrite.Log("Stopped Game");
			});
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!DesignMode)
			{
				DoMainLoop();
			}
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

		public new void Dispose()
		{
			Device.Dispose();
			Direct3D.Dispose();
			base.Dispose();
		}
	}
}