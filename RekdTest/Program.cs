using RekdEngine.Core;
using RekdNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdTest
{
	public static class Program
	{
		/// <summary>
		/// Entrypoint
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Net.SetLoginController(new DefaultLoginController("http://localhost:1337/"));
			Net.Login("webfreak", "123");
			using (Game1 game = new Game1())
			{
				game.Run("Rekd Test", 800, 480);
			}
		}
	}
}