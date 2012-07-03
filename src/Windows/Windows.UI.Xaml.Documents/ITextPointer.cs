using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(TextPointer)), Guid(2892528289u, 27201, 17407, 133, 30, 69, 52, 138, 162, 207, 123), Version(100794368u), WebHostHidden]
	internal interface ITextPointer
	{
		LogicalDirection LogicalDirection
		{
			get;
		}
		int Offset
		{
			get;
		}
		DependencyObject Parent
		{
			get;
		}
		FrameworkElement VisualParent
		{
			get;
		}
		Rect GetCharacterRect([In] LogicalDirection direction);
		TextPointer GetPositionAtOffset([In] int offset, [In] LogicalDirection direction);
	}
}
