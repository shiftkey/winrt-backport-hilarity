using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[Guid(4020898634u, 63202, 19837, 133, 108, 120, 252, 142, 252, 2, 30), Version(100794368u)]
	public delegate void MessageTransmittedHandler([In] ProximityDevice sender, [In] long messageId);
}
