using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RichTextBlock)), Guid(3858758114u, 47464, 18919, 151, 212, 140, 202, 42, 195, 174, 124), Version(100794368u), WebHostHidden]
	internal interface IRichTextBlock
	{
		event ContextMenuOpeningEventHandler ContextMenuOpening;
		event RoutedEventHandler SelectionChanged;
		double BaselineOffset
		{
			get;
		}
		BlockCollection Blocks
		{
			get;
		}
		int CharacterSpacing
		{
			get;
			set;
		}
		TextPointer ContentEnd
		{
			get;
		}
		TextPointer ContentStart
		{
			get;
		}
		FontFamily FontFamily
		{
			get;
			set;
		}
		double FontSize
		{
			get;
			set;
		}
		FontStretch FontStretch
		{
			get;
			set;
		}
		FontStyle FontStyle
		{
			get;
			set;
		}
		FontWeight FontWeight
		{
			get;
			set;
		}
		Brush Foreground
		{
			get;
			set;
		}
		bool HasOverflowContent
		{
			get;
		}
		bool IsTextSelectionEnabled
		{
			get;
			set;
		}
		double LineHeight
		{
			get;
			set;
		}
		LineStackingStrategy LineStackingStrategy
		{
			get;
			set;
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
		string SelectedText
		{
			get;
		}
		TextPointer SelectionEnd
		{
			get;
		}
		TextPointer SelectionStart
		{
			get;
		}
		TextAlignment TextAlignment
		{
			get;
			set;
		}
		TextTrimming TextTrimming
		{
			get;
			set;
		}
		TextWrapping TextWrapping
		{
			get;
			set;
		}
		void SelectAll();
		void Select([In] TextPointer start, [In] TextPointer end);
		TextPointer GetPositionFromPoint([In] Point point);
		bool Focus([In] FocusState value);
	}
}
