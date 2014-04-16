using SlimDX;
using SlimDX.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D2D = SlimDX.Direct2D;

namespace RekdEngine.Core
{
	public abstract class Game : RunnableRekd, IDisposable
	{
		/// <summary>
		/// Load Content here
		/// </summary>
		public abstract void Load();

		/// <summary>
		/// Require Librarys and define Post Process Shaders etc. here
		/// </summary>
		public abstract void Init();

		/// <summary>
		/// Unload all non Content variable stuff here
		/// </summary>
		public abstract void Unload();

		/// <summary>
		/// Draw your Scene here
		/// </summary>
		public abstract void Render();

		/// <summary>
		/// Update your Game Logic here
		/// </summary>
		public abstract void Update();

		public void Run(string Title, uint Width, uint Height)
		{
			Init();
			Load();
		}

		public void Dispose()
		{
			Unload();
		}
	}
}