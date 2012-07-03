using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ManipulationStartingRoutedEventArgs : RoutedEventArgs, IManipulationStartingRoutedEventArgs
	{
		public extern UIElement Container
		{
			get;
			set;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern ManipulationModes Mode
		{
			get;
			set;
		}
		public extern ManipulationPivot Pivot
		{
			get;
			set;
		}
		public extern ManipulationStartingRoutedEventArgs();
	}
}
