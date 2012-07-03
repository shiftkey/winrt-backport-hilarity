using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationStartedRoutedEventArgs)), Guid(1571924485u, 40832, 18614, 174, 108, 79, 17, 157, 232, 255, 19), Version(100794368u), WebHostHidden]
	internal interface IManipulationStartedRoutedEventArgs
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
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Point Position
		{
			get;
		}
		void Complete();
	}
}
