using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(PointerDevice)), Guid(3635976865u, 53702, 16750, 189, 141, 87, 144, 145, 77, 197, 99), Version(100794368u)]
	internal interface IPointerDeviceStatics
	{
		PointerDevice GetPointerDevice([In] uint pointerId);
		IVectorView<PointerDevice> GetPointerDevices();
	}
}
