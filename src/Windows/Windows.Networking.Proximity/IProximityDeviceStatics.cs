using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(ProximityDevice)), Guid(2437652509u, 63201, 18372, 161, 76, 20, 138, 25, 3, 208, 198), Version(100794368u)]
	internal interface IProximityDeviceStatics
	{
		string GetDeviceSelector();
		ProximityDevice GetDefault();
		ProximityDevice FromId([In] string deviceInterfaceId);
	}
}
