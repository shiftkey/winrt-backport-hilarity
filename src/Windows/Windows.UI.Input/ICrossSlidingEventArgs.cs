using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(CrossSlidingEventArgs)), Guid(3912714040u, 28552, 16857, 135, 32, 120, 224, 142, 57, 131, 73), Version(100794368u)]
	internal interface ICrossSlidingEventArgs
	{
		CrossSlidingState CrossSlidingState
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
