using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.Content
{
	public interface NonManagedRessource : IDisposable
	{
		void Reset();

		void Lost();
	}
}