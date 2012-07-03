using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationDeltaRoutedEventArgs)), Guid(1074616212u, 19567, 18717, 130, 214, 53, 23, 16, 147, 153, 198), Version(100794368u), WebHostHidden]
	internal interface IManipulationDeltaRoutedEventArgs
	{
		UIElement Container
		{
			get;
		}
		ManipulationDelta Cumulative
		{
			get;
		}
		ManipulationDelta Delta
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
		void Complete();
	}
}
