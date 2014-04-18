using RekdEngine;
using RekdEngine.Core;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			Clear(new Color(43, 78, 124));
			BeginScene();
			EndScene();
		}
	}
}