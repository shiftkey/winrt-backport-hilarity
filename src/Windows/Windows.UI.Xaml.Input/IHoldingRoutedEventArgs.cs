using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(HoldingRoutedEventArgs)), Guid(3259432739u, 55309, 17630, 141, 185, 13, 129, 94, 38, 154, 192), Version(100794368u), WebHostHidden]
	internal interface IHoldingRoutedEventArgs
	{
		bool Handled
		{
			get;
			set;
		}
		HoldingState HoldingState
		{
			get;
		}
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Point GetPosition([In] UIElement relativeTo);
	}
}
