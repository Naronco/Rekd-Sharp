using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekdEngine.Debug
{
	public class DebugWrite
	{
		public static bool DebugToConsole { get; set; }

		public static bool DebugToFile { get; set; }

		public static StreamWriter DebugFile { get; set; }

		public static void Log(object o = null)
		{
			string ln = (o ?? "").ToString();
			DateTime t = DateTime.UtcNow;

			if (DebugToConsole)
				Console.WriteLine(ln);
			if (DebugToFile)
				DebugFile.WriteLine("[" + t.ToLongTimeString() + "]: " + ln);
#if DEBUG
			System.Diagnostics.Debug.WriteLine(ln);
#endif
		}

		public static void Save()
		{
			DebugFile.Close();
			DebugFile.Dispose();
		}

		static DebugWrite()
		{
#if DEBUG
			DebugToFile = true;
			DebugToConsole = true;
			DebugFile = new StreamWriter(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "debug.log"));
#else
			DebugToFile = false;
			DebugToConsole = false;
			DebugFile = new StreamWriter(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "debug.log"));
#endif
			Log("Started debugging session at /debug.log");
		}
	}
}