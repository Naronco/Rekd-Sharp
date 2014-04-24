using RekdEngine.Content;
using RekdEngine.Core;
using RekdEngine.UtilMath;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.Render
{
	public class SpriteBatch
	{
		private Device Device;

		private VertexDeclaration cubeDecl;
		private VertexBuffer cubeVert;
		private Content.Effect renderEffect;

		public SpriteBatch(Device d, ContentManager c)
		{
			Device = d;

			cubeVert = new VertexBuffer(Device, 4 * 28, Usage.WriteOnly, VertexFormat.None, Pool.Managed);
			cubeVert.Lock(0, 0, LockFlags.None).WriteRange(new[]
			{
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(0, 0, 0.0f, 1.0f), TexCoord = new Vector2f(0.0f, 1.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(0, 1, 0.0f, 1.0f), TexCoord = new Vector2f(0.0f, 0.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(1, 0, 0.0f, 1.0f), TexCoord = new Vector2f(1.0f, 1.0f) },
				new VertexPositionTextureColor() { Color = Color.White.ToArgb(), Position = new Vector4f(1, 1, 0.0f, 1.0f), TexCoord = new Vector2f(1.0f, 0.0f) }
			});
			cubeVert.Unlock();

			var cubeElems = new[]
			{
				new VertexElement(0, 0, DeclarationType.Float4, DeclarationMethod.Default, DeclarationUsage.Position, 0),
				new VertexElement(0, 16, DeclarationType.Float2, DeclarationMethod.Default, DeclarationUsage.TextureCoordinate, 0),
				new VertexElement(0, 24, DeclarationType.Color, DeclarationMethod.Default, DeclarationUsage.Color, 0),
				VertexElement.VertexDeclarationEnd
			};

			cubeDecl = new VertexDeclaration(Device, cubeElems);

			renderEffect = c.LoadString<Content.Effect>("float4 c;Texture b;sampler s=sampler_state{texture=<b>;magfilter=LINEAR;minfilter=LINEAR;mipfilter=LINEAR;AddressU=wrap;AddressV=wrap;};float4 f(float2 t:TEXCOORD0):COLOR{return tex2D(s, t) * c;}technique t{pass p{PixelShader = compile ps_2_0 f();}}");
		}

		public void Begin(Color clear)
		{
			Device.BeginScene();
			Device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, clear.AsSharpDXBGRA(), 1.0f, 0);
		}

		public void End()
		{
			Device.EndScene();
		}

		public void Draw(Texture2D texture, Vector2f position, Color color)
		{
			renderEffect.Begin();
			renderEffect.BeginPass(0);

			texture.Bind(0);
			renderEffect.SetColor("c", color);
			DrawPrimitive(new Rectangle(position, texture.Width, texture.Height));

			renderEffect.EndPass();
			renderEffect.End();
		}

		public void Draw(Texture2D texture, Rectangle size, Color color)
		{
			renderEffect.Begin();
			renderEffect.BeginPass(0);

			texture.Bind(0);
			renderEffect.SetColor("c", color);
			DrawPrimitive(size);

			renderEffect.EndPass();
			renderEffect.End();
		}

		public void DrawPrimitive(Rectangle r)
		{
			Device.SetTransform(TransformState.World, SharpDX.Matrix.Scaling(r.Width, r.Height, 1) * SharpDX.Matrix.Translation(-Device.Viewport.Width * 0.5f + r.X, Device.Viewport.Height * 0.5f - r.Height + r.Y, 0));

			Device.SetStreamSource(0, cubeVert, 0, 28);
			Device.VertexDeclaration = cubeDecl;
			Device.DrawPrimitives(PrimitiveType.TriangleStrip, 0, 2);
		}
	}
}