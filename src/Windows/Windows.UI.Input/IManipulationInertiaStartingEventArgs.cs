using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(ManipulationInertiaStartingEventArgs)), Guid(3711412376u, 9919, 18042, 156, 229, 204, 243, 251, 17, 55, 30), Version(100794368u)]
	internal interface IManipulationInertiaStartingEventArgs
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
