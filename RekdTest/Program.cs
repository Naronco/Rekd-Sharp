using RekdEngine.Core;
using RekdEngine.UtilMath;
using RekdNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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
			using (Game1 game = new Game1())
			{
				game.Run("Rekd Test", 640, 480);
			}
		}
	}
}