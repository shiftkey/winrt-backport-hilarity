using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[Guid(1522270171u, 49695, 19396, 137, 27, 37, 126, 40, 193, 177, 164), Version(100794368u)]
	public delegate void DialRequestedEventHandler([In] CallControl sender, [In] DialRequestedEventArgs e);
}
