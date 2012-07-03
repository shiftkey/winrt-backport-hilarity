using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(ManipulationCompletedEventArgs)), Guid(3008016939u, 53659, 18175, 159, 56, 222, 199, 117, 75, 185, 231), Version(100794368u)]
	internal interface IManipulationCompletedEventArgs
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
		ManipulationVelocities Velocities
		{
			get;
		}
	}
}
