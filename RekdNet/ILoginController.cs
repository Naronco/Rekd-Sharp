using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdNet
{
	public interface ILoginController
	{
		string Decrypt(string s);

		string Encrypt(string s);

		void Login(string username, string password);
	}
}