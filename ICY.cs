using System;
using System.Diagnostics;

//ImplicateX.TinyCLR.Components.Web

//└─ ICY
//    ├─ Stream
//    ├─ Player
//    ├─ Information
//    ├─ Metadata
//    └─ UrlResolver

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
