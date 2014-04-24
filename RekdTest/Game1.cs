using RekdEngine;
using RekdEngine.Content;
using RekdEngine.Core;
using RekdEngine.Debug;
using RekdEngine.Event;
using RekdEngine.Render;
using RekdEngine.UtilMath;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using D3D = SharpDX.Direct3D9;

using SDX = SharpDX;

namespace RekdTest
{
	public class Game1 : Game
	{
		private D3D.VertexDeclaration VertexDecl;
		private D3D.VertexBuffer vertices;
		private Texture2D tex;
		private Texture2D tex2;
		private Effect effect;
		private D3D.VertexDeclaration cubeDecl;
		private D3D.VertexBuffer cubeVert;

		public override void Init()
		{
		}

		public override void Load()
		{
			tex = Content.Load<Texture2D>("example.dds");
			tex2 = Content.Load<Texture2D>("mask.dds");
			effect = Content.Load<Effect>("example.fx");

			//tex.AutoMipGenerationFilter = TextureFilter.Anisotropic;
			//tex.GenerateMipSublevels();
			vertices = new D3D.VertexBuffer(Device, 3 * 28, D3D.Usage.WriteOnly, D3D.VertexFormat.None, D3D.Pool.Managed);
			vertices.Lock(0, 0, D3D.LockFlags.None).WriteRange(new[]
			{
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(-0.5f, -1, 0.0f, 1.0f), TexCoord = new Vector2f(0.0f, 1.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(0, 1, 0.0f, 1.0f), TexCoord = new Vector2f(0.5f, 0.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(1, -1, 0.0f, 1.0f), TexCoord = new Vector2f(1.0f, 1.0f) }
			});
			vertices.Unlock();

			var vertexElems = new[]
			{
				new D3D.VertexElement(0, 0, D3D.DeclarationType.Float4, D3D.DeclarationMethod.Default, D3D.DeclarationUsage.Position, 0),
				new D3D.VertexElement(0, 16, D3D.DeclarationType.Float2, D3D.DeclarationMethod.Default, D3D.DeclarationUsage.TextureCoordinate, 0),
				new D3D.VertexElement(0, 24, D3D.DeclarationType.Color, D3D.DeclarationMethod.Default, D3D.DeclarationUsage.Color, 0),
				D3D.VertexElement.VertexDeclarationEnd
			};

			VertexDecl = new D3D.VertexDeclaration(Device, vertexElems);

			cubeVert = new D3D.VertexBuffer(Device, 4 * 28, D3D.Usage.WriteOnly, D3D.VertexFormat.None, D3D.Pool.Managed);
			cubeVert.Lock(0, 0, D3D.LockFlags.None).WriteRange(new[]
			{
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(-1, -1, 0.0f, 1.0f), TexCoord = new Vector2f(0.0f, 1.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(-1, 1, 0.0f, 1.0f), TexCoord = new Vector2f(0.0f, 0.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(1, -1, 0.0f, 1.0f), TexCoord = new Vector2f(1.0f, 1.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(1, 1, 0.0f, 1.0f), TexCoord = new Vector2f(1.0f, 0.0f) }
			});
			cubeVert.Unlock();

			var cubeElems = new[]
			{
				new D3D.VertexElement(0, 0, D3D.DeclarationType.Float4, D3D.DeclarationMethod.Default, D3D.DeclarationUsage.Position, 0),
				new D3D.VertexElement(0, 16, D3D.DeclarationType.Float2, D3D.DeclarationMethod.Default, D3D.DeclarationUsage.TextureCoordinate, 0),
				new D3D.VertexElement(0, 24, D3D.DeclarationType.Color, D3D.DeclarationMethod.Default, D3D.DeclarationUsage.Color, 0),
				D3D.VertexElement.VertexDeclarationEnd
			};

			cubeDecl = new D3D.VertexDeclaration(Device, cubeElems);
		}

		public override void Unload()
		{
			cubeDecl.Dispose();
			cubeVert.Dispose();
			VertexDecl.Dispose();
			vertices.Dispose();
			tex.Dispose();
			tex2.Dispose();
			effect.Dispose();
		}

		public override void Update(TimeSpan delta)
		{
		}

		public override void Render(TimeSpan delta)
		{
			Clear(new Color(43, 78, 124));

			SDX.Matrix proj = Device.GetTransform(D3D.TransformState.Projection);
			SDX.Matrix view = Device.GetTransform(D3D.TransformState.View);
			SDX.Matrix world = Device.GetTransform(D3D.TransformState.World);

			effect.SetMatrix("World", world);
			effect.SetMatrix("View", view);
			effect.SetMatrix("Projection", proj);

			BeginScene();
			Device.SetTransform(D3D.TransformState.Projection, SharpDX.Matrix.Identity);

			effect.Begin();
			effect.BeginPass(0);

			tex.Bind(0);
			tex2.Bind(1);
			Device.SetStreamSource(0, cubeVert, 0, 28);
			Device.VertexDeclaration = cubeDecl;
			Device.DrawPrimitives(D3D.PrimitiveType.TriangleStrip, 0, 2);

			effect.EndPass();
			effect.End();

			EndScene();
		}
	}
}