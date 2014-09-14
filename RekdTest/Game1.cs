using RekdEngine.Content;
using RekdEngine.Core;
using RekdEngine.UtilMath;
using System;

namespace RekdTest
{
	public class Game1 : Game
	{
		public override void Init()
		{
		}

		public override void Load()
		{
		}

		public override void Unload()
		{
		}

		public override void Update(TimeSpan delta)
		{
		}

		public override void Render(TimeSpan delta)
		{
			SpriteBatch.Begin(new Color(43, 78, 124));

			SpriteBatch.Draw(Resources.Crate, new Rectangle(0, 0, 512, 512), Color.Red);

			SpriteBatch.End();
		}
	}
}