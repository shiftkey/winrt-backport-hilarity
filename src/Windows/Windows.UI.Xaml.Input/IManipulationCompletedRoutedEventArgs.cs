using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationCompletedRoutedEventArgs)), Guid(3048053539u, 12097, 18830, 131, 25, 1, 94, 232, 167, 83, 70), Version(100794368u), WebHostHidden]
	internal interface IManipulationCompletedRoutedEventArgs
	{
		UIElement Container
		{
			get;
		}
		ManipulationDelta Cumulative
		{
			get;
		}
		bool Handled
		{
			get;
			set;
		}
		bool IsInertial
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
