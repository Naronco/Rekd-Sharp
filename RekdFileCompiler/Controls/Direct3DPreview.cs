using RekdEngine.Content;
using RekdEngine.Event;
using RekdEngine.Render;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdFileCompiler.Controls
{
	public partial class Direct3DPreview : UserControl
	{
		private Direct3D Direct3D;

		public Device Device { get; set; }

		public SpriteBatch spriteBatch { get; set; }

		public ContentManager Content { get; set; }

		public string Title { get { return label1.Text; } set { label1.Text = value; } }

		public RekdEngine.Core.Color ClearColor { get; set; }

		private bool Initialized = false;

		public float ViewportWidth { get { return (float)dxViewport.Width; } }

		public float ViewportHeight { get { return (float)dxViewport.Height; } }

		public Direct3DPreview()
		{
			InitializeComponent();
		}

		public void Initialize()
		{
			Direct3D = new Direct3D();
			Device = new Device(Direct3D, 0, DeviceType.Hardware, dxViewport.Handle, CreateFlags.HardwareVertexProcessing, new PresentParameters(dxViewport.Width, dxViewport.Height));
			Device.SetTransform(TransformState.Projection, Matrix.OrthoLH(dxViewport.Width, dxViewport.Height, -1, 1));
			Device.SetRenderState(RenderState.AlphaBlendEnable, true);
			Device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
			Device.SetRenderState(RenderState.DestinationBlend, Blend.InverseSourceAlpha);

			Content = new ContentManager(Device);
			spriteBatch = new SpriteBatch(Device, Content);

			Initialized = true;
		}

		public void Start(Action<int, int> render)
		{
			if (Initialized)
				RenderLoop.Run(dxViewport, () =>
				{
					render(dxViewport.Width, dxViewport.Height);
				});
		}

		private void dxViewport_Resize(object sender, EventArgs e)
		{
			if (Initialized)
			{
				GameEventListener.RunResizeEvent(null, new Size(dxViewport.Width, dxViewport.Height));
				Device.Reset(new PresentParameters(dxViewport.Width, dxViewport.Height));
				GameEventListener.RunDeviceResetEvent(null, Device);
				Device.SetTransform(TransformState.Projection, Matrix.OrthoLH(dxViewport.Width, dxViewport.Height, -1, 1));
				Device.SetRenderState(RenderState.AlphaBlendEnable, true);
				Device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
				Device.SetRenderState(RenderState.DestinationBlend, Blend.InverseSourceAlpha);
			}
		}
	}
}