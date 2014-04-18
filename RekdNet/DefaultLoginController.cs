using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RekdNet
{
	public class DefaultLoginController : ILoginController
	{
		public RSACryptoServiceProvider rsaProvider { get; protected set; }

		public RSACryptoServiceProvider serverRsa { get; protected set; }

		public string LoginServer
		{
			get
			{
				return FormattedLoginServer;
			}

			set
			{
				if (value.EndsWith("/")) FormattedLoginServer = value;
				else FormattedLoginServer = value + "/";
			}
		}

		protected string FormattedLoginServer { get; set; }

		public DefaultLoginController(string loginServer)
		{
			rsaProvider = new RSACryptoServiceProvider(2048);
			serverRsa = new RSACryptoServiceProvider(2048);
			LoginServer = loginServer;
		}

		public string Decrypt(string s)
		{
			return Encoding.Unicode.GetString(rsaProvider.Decrypt(Encoding.Unicode.GetBytes(s), false));
		}

		public string Encrypt(string s)
		{
			return Encoding.Unicode.GetString(serverRsa.Encrypt(Encoding.Unicode.GetBytes(s), false));
		}

		public void Login(string username, string password)
		{
			string rsa = rsaProvider.ToXmlString(false);
			Console.WriteLine(rsa);
			string serverKey = HttpPost("ShareKeys", new Dictionary<string, string> { { "RSA", rsa } });
			serverRsa.FromXmlString(serverKey);
		}

		public string HttpPost(string page, Dictionary<string, string> Parameters)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(LoginServer + page);
			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded";

			//string postData = "home=Cosby&favorite+flavor=flies";
			var postData = string.Join("&", (from keyval in Parameters let str = HttpUtility.HtmlEncode(keyval.Key) + "=" + HttpUtility.HtmlEncode(keyval.Value) select str));
			byte[] bytes = Encoding.UTF8.GetBytes(postData);
			request.ContentLength = bytes.Length;

			Stream requestStream = request.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);

			WebResponse response = request.GetResponse();
			Stream stream = response.GetResponseStream();
			StreamReader reader = new StreamReader(stream);

			var result = reader.ReadToEnd();
			stream.Dispose();
			reader.Dispose();
			return result;
		}
	}
}