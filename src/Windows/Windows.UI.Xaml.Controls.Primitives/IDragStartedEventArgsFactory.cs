using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(DragStartedEventArgs)), Guid(1592780153u, 50950, 18305, 163, 8, 201, 231, 244, 198, 161, 215), Version(100794368u), WebHostHidden]
	internal interface IDragStartedEventArgsFactory
	{
		DragStartedEventArgs CreateInstanceWithHorizontalOffsetAndVerticalOffset([In] double horizontalOffset, [In] double verticalOffset, [In] object outer, out object inner);
	}
}
