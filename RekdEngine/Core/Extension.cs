using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RekdEngine.Core
{
	public class Extension
	{
		public static Assembly LoadBinary(string file)
		{
			return Assembly.LoadFrom("Modules/" + file);
		}
	}
}