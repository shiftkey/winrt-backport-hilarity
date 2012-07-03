using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(MouseDevice)), Guid(1212846149u, 28016, 18907, 142, 104, 70, 255, 189, 23, 211, 141), Version(100794368u)]
	internal interface IMouseDeviceStatics
	{
		MouseDevice GetForCurrentView();
	}
}
