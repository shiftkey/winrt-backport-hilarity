using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILayoutInformationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class LayoutInformation : ILayoutInformation
	{
		public static extern UIElement GetLayoutExceptionElement([In] object dispatcher);
		public static extern Rect GetLayoutSlot([In] FrameworkElement element);
	}
}
