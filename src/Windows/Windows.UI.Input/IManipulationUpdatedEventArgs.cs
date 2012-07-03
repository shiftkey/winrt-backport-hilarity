using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(ManipulationUpdatedEventArgs)), Guid(3409267941u, 43960, 20383, 179, 206, 129, 129, 170, 97, 173, 130), Version(100794368u)]
	internal interface IManipulationUpdatedEventArgs
	{
		ManipulationDelta Cumulative
		{
			get;
		}
		ManipulationDelta Delta
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
