using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ManipulationCompletedRoutedEventArgs : RoutedEventArgs, IManipulationCompletedRoutedEventArgs
	{
		public extern UIElement Container
		{
			get;
		}
		public extern ManipulationDelta Cumulative
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern bool IsInertial
		{
			get;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern Point Position
		{
			get;
		}
		public extern ManipulationVelocities Velocities
		{
			get;
		}
		public extern ManipulationCompletedRoutedEventArgs();
	}
}
