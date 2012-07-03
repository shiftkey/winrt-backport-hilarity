using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(ManipulationStartedEventArgs)), Guid(3723265854u, 53198, 18738, 140, 29, 60, 61, 1, 26, 52, 192), Version(100794368u)]
	internal interface IManipulationStartedEventArgs
	{
		ManipulationDelta Cumulative
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
