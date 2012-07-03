using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(DoubleTappedRoutedEventArgs)), Guid(2940224548u, 9951, 17652, 135, 20, 147, 89, 36, 155, 98, 211), Version(100794368u), WebHostHidden]
	internal interface IDoubleTappedRoutedEventArgs
	{
		bool Handled
		{
			get;
			set;
		}
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Point GetPosition([In] UIElement relativeTo);
	}
}
