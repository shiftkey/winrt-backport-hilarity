using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[Guid(1908020287u, 22926, 18896, 132, 235, 143, 235, 174, 220, 193, 149), Version(100794368u)]
	public delegate void NetworkStatusChangedEventHandler([In] object sender);
}
