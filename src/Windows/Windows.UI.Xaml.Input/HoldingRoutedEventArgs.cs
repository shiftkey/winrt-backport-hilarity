using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class HoldingRoutedEventArgs : RoutedEventArgs, IHoldingRoutedEventArgs
	{
		public extern bool Handled
		{
			get;
			set;
		}
		public extern HoldingState HoldingState
		{
			get;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern HoldingRoutedEventArgs();
		public extern Point GetPosition([In] UIElement relativeTo);
	}
}
