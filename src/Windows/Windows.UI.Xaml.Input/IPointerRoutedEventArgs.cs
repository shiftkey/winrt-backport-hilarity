using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(PointerRoutedEventArgs)), Guid(3663892234u, 38738, 18914, 189, 226, 73, 236, 202, 185, 25, 77), Version(100794368u), WebHostHidden]
	internal interface IPointerRoutedEventArgs
	{
		bool Handled
		{
			get;
			set;
		}
		VirtualKeyModifiers KeyModifiers
		{
			get;
		}
		Pointer Pointer
		{
			get;
		}
		PointerPoint GetCurrentPoint([In] UIElement relativeTo);
		IVector<PointerPoint> GetIntermediatePoints([In] UIElement relativeTo);
	}
}
