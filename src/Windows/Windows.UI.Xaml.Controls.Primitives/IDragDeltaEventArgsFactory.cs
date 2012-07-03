using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(DragDeltaEventArgs)), Guid(1189585391u, 44565, 17574, 138, 4, 149, 176, 191, 154, 184, 118), Version(100794368u), WebHostHidden]
	internal interface IDragDeltaEventArgsFactory
	{
		DragDeltaEventArgs CreateInstanceWithHorizontalChangeAndVerticalChange([In] double horizontalChange, [In] double verticalChange, [In] object outer, out object inner);
	}
}
