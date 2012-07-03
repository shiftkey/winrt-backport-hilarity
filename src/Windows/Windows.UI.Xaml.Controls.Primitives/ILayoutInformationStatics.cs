using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(LayoutInformation)), Guid(3473330073u, 22761, 18050, 131, 38, 80, 202, 171, 101, 237, 124), Version(100794368u), WebHostHidden]
	internal interface ILayoutInformationStatics
	{
		UIElement GetLayoutExceptionElement([In] object dispatcher);
		Rect GetLayoutSlot([In] FrameworkElement element);
	}
}
