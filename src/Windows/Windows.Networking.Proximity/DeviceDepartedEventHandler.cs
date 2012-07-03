using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[Guid(4020886121u, 63202, 18889, 164, 158, 142, 15, 197, 143, 185, 17), Version(100794368u)]
	public delegate void DeviceDepartedEventHandler([In] ProximityDevice sender);
}
