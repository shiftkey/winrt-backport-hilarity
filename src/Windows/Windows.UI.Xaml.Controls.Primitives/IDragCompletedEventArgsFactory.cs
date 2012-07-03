using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(DragCompletedEventArgs)), Guid(916969885u, 5260, 18783, 160, 252, 175, 200, 113, 214, 47, 51), Version(100794368u), WebHostHidden]
	internal interface IDragCompletedEventArgsFactory
	{
		DragCompletedEventArgs CreateInstanceWithHorizontalChangeVerticalChangeAndCanceled([In] double horizontalChange, [In] double verticalChange, [In] bool canceled, [In] object outer, out object inner);
	}
}
