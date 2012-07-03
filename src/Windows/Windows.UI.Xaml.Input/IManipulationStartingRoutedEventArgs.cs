using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationStartingRoutedEventArgs)), Guid(416691895u, 21412, 19477, 164, 152, 243, 169, 202, 33, 42, 66), Version(100794368u), WebHostHidden]
	internal interface IManipulationStartingRoutedEventArgs
	{
		UIElement Container
		{
			get;
			set;
		}
		bool Handled
		{
			get;
			set;
		}
		ManipulationModes Mode
		{
			get;
			set;
		}
		ManipulationPivot Pivot
		{
			get;
			set;
		}
	}
}
