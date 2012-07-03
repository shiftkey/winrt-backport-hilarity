using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(TappedRoutedEventArgs)), Guid(2694440638u, 58916, 17818, 187, 29, 224, 92, 115, 226, 204, 102), Version(100794368u), WebHostHidden]
	internal interface ITappedRoutedEventArgs
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
