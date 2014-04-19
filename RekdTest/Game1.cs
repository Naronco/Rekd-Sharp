using RekdEngine;
using RekdEngine.Core;
using RekdEngine.Debug;
using RekdEngine.Event;
using RekdEngine.Render;
using RekdEngine.UtilMath;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdTest
{
	public class Game1 : Game
	{
		private VertexDeclaration VertexDecl;
		private VertexBuffer vertices;
		private Texture tex;
		private Effect effect;

		public override void Init()
		{
			GameEventListener.ResizeEvent += GameEventListener_ResizeEvent;
			GameEventListener.DeviceResetEvent += GameEventListener_DeviceResetEvent;
		}

		private void GameEventListener_DeviceResetEvent(Form Window, Device d)
		{
			effect.OnResetDevice();
		}

		private void GameEventListener_ResizeEvent(Form Window, System.Drawing.Size e)
		{
			effect.OnLostDevice();
		}

		public override void Load()
		{
			tex = Texture.FromFile(Device, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "example.dds"), Usage.None, Pool.Managed);

			//tex.AutoMipGenerationFilter = TextureFilter.Anisotropic;
			//tex.GenerateMipSublevels();
			vertices = new VertexBuffer(Device, 3 * 28, Usage.WriteOnly, VertexFormat.None, Pool.Managed);
			vertices.Lock(0, 0, LockFlags.None).WriteRange(new[]
			{
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(-0.5f, -1, 0.0f, 1.0f), TexCoord = new Vector2f(0.0f, 1.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(0, 1, 0.0f, 1.0f), TexCoord = new Vector2f(0.5f, 0.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(1, -1, 0.0f, 1.0f), TexCoord = new Vector2f(1.0f, 1.0f) }
			});
			vertices.Unlock();

			var vertexElems = new[]
			{
				new VertexElement(0, 0, DeclarationType.Float4, DeclarationMethod.Default, DeclarationUsage.Position, 0),
				new VertexElement(0, 16, DeclarationType.Float2, DeclarationMethod.Default, DeclarationUsage.TextureCoordinate, 0),
				new VertexElement(0, 24, DeclarationType.Color, DeclarationMethod.Default, DeclarationUsage.Color, 0),
				VertexElement.VertexDeclarationEnd
			};

			VertexDecl = new VertexDeclaration(Device, vertexElems);

			effect = Effect.FromFile(Device, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "example.fx"), ShaderFlags.None);
		}

		public override void Unload()
		{
		}

		public override void Update(TimeSpan delta)
		{
		}

		public override void Render(TimeSpan delta)
		{
			Clear(new Color(43, 78, 124));
			BeginScene();
			Device.SetTransform(TransformState.Projection, SlimDX.Matrix.Identity);

			//Device.SetTransform(TransformState.World, SlimDX.Matrix.Translation(1, 0, 0));
			effect.Begin();
			effect.BeginPass(0);
			Device.SetTexture(0, tex);
			Device.SetStreamSource(0, vertices, 0, 28);
			Device.VertexDeclaration = VertexDecl;
			Device.DrawPrimitives(PrimitiveType.TriangleList, 0, 1);

			effect.EndPass();
			effect.End();
			EndScene();
		}
	}
}