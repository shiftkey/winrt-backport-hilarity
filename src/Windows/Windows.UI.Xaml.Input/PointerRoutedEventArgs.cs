using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PointerRoutedEventArgs : RoutedEventArgs, IPointerRoutedEventArgs
	{
		public extern bool Handled
		{
			get;
			set;
		}
		public extern VirtualKeyModifiers KeyModifiers
		{
			get;
		}
		public extern Pointer Pointer
		{
			get;
		}
		public extern PointerPoint GetCurrentPoint([In] UIElement relativeTo);
		public extern IVector<PointerPoint> GetIntermediatePoints([In] UIElement relativeTo);
	}
}
