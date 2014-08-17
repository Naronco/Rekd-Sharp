using RekdEngine.Content;
using RekdEngine.Core;
using RekdEngine.UtilMath;
using System;

namespace RekdTest
{
	public class Game1 : Game
	{
		private Texture2D tex;
		private Texture2D tex2;

		//private World world;

		public override void Init()
		{
			//world = new World(new Vec2(0, -9.7f), true);
			//CreateGround();
			//CreateShape();
		}

		/*
		public void CreateGround()
		{
			BodyDef groundBodyDef = new BodyDef();
			groundBodyDef.Position = new Vec2(0, -10.0f);
			Body groundBody = world.CreateBody(groundBodyDef);
			PolygonShape groundBox = new PolygonShape();
			groundBox.SetAsBox(50, 10);
			groundBody.CreateFixture(groundBox, 0.0f);
		}

		public void CreateShape()
		{
			BodyDef bodyDef = new BodyDef();
			bodyDef.BodyType = EBodyType.b2_dynamicBody;
			bodyDef.Position = new Vec2(0, 4.0f);
			Body body = world.CreateBody(bodyDef);
			PolygonShape boxShape = new PolygonShape();
			boxShape.SetAsBox(1, 1);
			FixtureDef fixtureDef = new FixtureDef();
			fixtureDef.Shape = boxShape;
			fixtureDef.Density = 1.0f;
			fixtureDef.Friction = 0.3f;

			//new BoxShape(world, size, new ShapeDescription() { Density = 1.0f, Friction = 0.3f })

			for (int i = 0; i < 100; ++i)
			{
				world.Step(1 / 60.0f, 6, 2);
				Vec2 position = body.Position;
				float angle = body.Angle;

				Console.WriteLine("Step: {3} - X: {0}, Y: {1}, Angle: {2}", new object[] { position.x.ToString(), position.y.ToString(), angle.ToString(), i.ToString() });
			}
		}
		*/

		public override void Load()
		{
			tex = Content.Load<Texture2D>("example.dds");
			tex2 = Content.Load<Texture2D>("mask.dds");
		}

		public override void Unload()
		{
		}

		public override void Update(TimeSpan delta)
		{
		}

		public override void Render(TimeSpan delta)
		{
			spriteBatch.Begin(new Color(43, 78, 124));

			spriteBatch.Draw(tex, new Rectangle(0, 0, 512, 512), Color.White);

			spriteBatch.Draw(tex2, new Rectangle(0, 0, 512, 512), Color.White);

			spriteBatch.End();
		}
	}
}