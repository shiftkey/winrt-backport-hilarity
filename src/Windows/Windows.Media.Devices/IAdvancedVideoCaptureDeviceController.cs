using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(VideoDeviceController)), Guid(3731879123u, 11158, 17795, 128, 171, 181, 176, 29, 198, 168, 215), Version(100794368u)]
	internal interface IAdvancedVideoCaptureDeviceController
	{
		void SetDeviceProperty([In] string propertyId, [Variant] [In] object propertyValue);
		[return: Variant]
		object GetDeviceProperty([In] string propertyId);
	}
}
