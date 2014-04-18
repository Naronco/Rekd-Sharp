using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdNet
{
	public class Net
	{
		private static ILoginController Controller;

		public static void SetLoginController(ILoginController controller)
		{
			Controller = controller;
		}

		public static void Login(string username, string password)
		{
			Controller.Login(username, password);
		}
	}
}