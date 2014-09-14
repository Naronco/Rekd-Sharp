using RekdFileCompiler.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdFileCompiler
{
	internal static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			SpritemapFormat ex = new SpritemapFormat() { Name = "Herp", Version = 3, Type = ContentType.SpriteMap };

			ex.GetType().GetProperties().ToList().ForEach(prop => Console.WriteLine("Property: " + prop.Name));

			Console.WriteLine(Encoding.UTF8.GetString(FileConverter.Serialize(ex)));

			Console.ReadKey();
			return;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FileCompiler());
		}
	}
}