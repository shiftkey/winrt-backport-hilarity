using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Guid(2514117692u, 28089, 16971, 134, 202, 9, 26, 244, 50, 8, 28), Version(100794368u)]
	public delegate void ComponentLoadFailedEventHandler([In] MediaProtectionManager sender, [In] ComponentLoadFailedEventArgs e);
}
