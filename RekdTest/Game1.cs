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
		private Texture2D tex;
		private Texture2D tex2;

		public override void Init()
		{
		}

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