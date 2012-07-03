using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[Guid(4020963202u, 63202, 18037, 160, 69, 216, 227, 32, 194, 72, 8), Version(100794368u)]
	public delegate void MessageReceivedHandler([In] ProximityDevice sender, [In] ProximityMessage message);
}
