using System;
using System.Diagnostics;

namespace ImplicateX.TinyCLR.Components.Web
{
	public sealed partial class ICY : IDisposable
	{
		private bool disposed = false;
		private readonly object syncRoot = new();

		/// <summary>
		/// Releases all resources used by this instance.
		/// </summary>
		public void Dispose()
		{
			if( disposed )
			{
				return;
			}

			disposed = true;
		}

	}
}
