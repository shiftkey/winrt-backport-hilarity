using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(RightTappedRoutedEventArgs)), Guid(1748272797u, 31701, 16435, 178, 55, 23, 47, 121, 171, 227, 147), Version(100794368u), WebHostHidden]
	internal interface IRightTappedRoutedEventArgs
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
