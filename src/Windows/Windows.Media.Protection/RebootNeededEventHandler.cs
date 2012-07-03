using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Guid(1692478021u, 38715, 19002, 178, 96, 145, 137, 138, 73, 168, 44), Version(100794368u)]
	public delegate void RebootNeededEventHandler([In] MediaProtectionManager sender);
}
