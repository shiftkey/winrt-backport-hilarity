using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[Composable(typeof(IManipulationStartedRoutedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ManipulationStartedRoutedEventArgs : RoutedEventArgs, IManipulationStartedRoutedEventArgs
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
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern Point Position
		{
			get;
		}
		public extern ManipulationStartedRoutedEventArgs();
		public extern void Complete();
	}
}
