using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[Guid(3136444369u, 20157, 19332, 159, 71, 110, 196, 61, 117, 216, 177), Version(100794368u)]
	public delegate void RedialRequestedEventHandler([In] CallControl sender, [In] RedialRequestedEventArgs e);
}
