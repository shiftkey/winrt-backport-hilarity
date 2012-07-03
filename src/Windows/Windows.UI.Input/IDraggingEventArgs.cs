using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(DraggingEventArgs)), Guid(479220612u, 2108, 19411, 181, 89, 23, 156, 221, 235, 51, 236), Version(100794368u)]
	internal interface IDraggingEventArgs
	{
		DraggingState DraggingState
		{
			get;
		}
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Point Position
		{
			get;
		}
	}
}
