using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(TextBlock)), Guid(2922222193u, 15178, 17916, 132, 104, 247, 148, 149, 72, 244, 213), Version(100794368u), WebHostHidden]
	internal interface ITextBlock
	{
		event ContextMenuOpeningEventHandler ContextMenuOpening;
		event RoutedEventHandler SelectionChanged;
		double BaselineOffset
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
		InlineCollection Inlines
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
		string Text
		{
			get;
			set;
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
		bool Focus([In] FocusState value);
	}
}
