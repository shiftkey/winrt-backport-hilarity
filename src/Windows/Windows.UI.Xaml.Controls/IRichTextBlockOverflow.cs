using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RichTextBlockOverflow)), Guid(1335063707u, 56003, 19010, 156, 187, 153, 240, 222, 55, 192, 113), Version(100794368u), WebHostHidden]
	internal interface IRichTextBlockOverflow
	{
		double BaselineOffset
		{
			get;
		}
		TextPointer ContentEnd
		{
			get;
		}
		RichTextBlock ContentSource
		{
			get;
		}
		TextPointer ContentStart
		{
			get;
		}
		bool HasOverflowContent
		{
			get;
		}
		RichTextBlockOverflow OverflowContentTarget
		{
			get;
			set;
		}
		Thickness Padding
		{
			get;
			set;
		}
		TextPointer GetPositionFromPoint([In] Point point);
		bool Focus([In] FocusState value);
	}
}
