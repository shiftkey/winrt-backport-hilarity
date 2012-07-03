using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(PointerDevice)), Guid(2479471356u, 60363, 18046, 130, 198, 39, 111, 234, 227, 107, 90), Version(100794368u)]
	internal interface IPointerDevice
	{
		bool IsIntegrated
		{
			get;
		}
		uint MaxContacts
		{
			get;
		}
		Rect PhysicalDeviceRect
		{
			get;
		}
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Rect ScreenRect
		{
			get;
		}
		IVectorView<PointerDeviceUsage> SupportedUsages
		{
			get;
		}
	}
}
