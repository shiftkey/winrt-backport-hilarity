using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITextBlockStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Inlines")]
	public sealed class TextBlock : FrameworkElement, ITextBlock
	{
		public extern event ContextMenuOpeningEventHandler ContextMenuOpening
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler SelectionChanged
		{
			add;
			remove;
		}
		public extern double BaselineOffset
		{
			get;
		}
		public extern int CharacterSpacing
		{
			get;
			set;
		}
		public extern TextPointer ContentEnd
		{
			get;
		}
		public extern TextPointer ContentStart
		{
			get;
		}
		public extern FontFamily FontFamily
		{
			get;
			set;
		}
		public extern double FontSize
		{
			get;
			set;
		}
		public extern FontStretch FontStretch
		{
			get;
			set;
		}
		public extern FontStyle FontStyle
		{
			get;
			set;
		}
		public extern FontWeight FontWeight
		{
			get;
			set;
		}
		public extern Brush Foreground
		{
			get;
			set;
		}
		public extern InlineCollection Inlines
		{
			get;
		}
		public extern bool IsTextSelectionEnabled
		{
			get;
			set;
		}
		public extern double LineHeight
		{
			get;
			set;
		}
		public extern LineStackingStrategy LineStackingStrategy
		{
			get;
			set;
		}
		public extern Thickness Padding
		{
			get;
			set;
		}
		public extern string SelectedText
		{
			get;
		}
		public extern TextPointer SelectionEnd
		{
			get;
		}
		public extern TextPointer SelectionStart
		{
			get;
		}
		public extern string Text
		{
			get;
			set;
		}
		public extern TextAlignment TextAlignment
		{
			get;
			set;
		}
		public extern TextTrimming TextTrimming
		{
			get;
			set;
		}
		public extern TextWrapping TextWrapping
		{
			get;
			set;
		}
		public static extern DependencyProperty CharacterSpacingProperty
		{
			get;
		}
		public static extern DependencyProperty FontFamilyProperty
		{
			get;
		}
		public static extern DependencyProperty FontSizeProperty
		{
			get;
		}
		public static extern DependencyProperty FontStretchProperty
		{
			get;
		}
		public static extern DependencyProperty FontStyleProperty
		{
			get;
		}
		public static extern DependencyProperty FontWeightProperty
		{
			get;
		}
		public static extern DependencyProperty ForegroundProperty
		{
			get;
		}
		public static extern DependencyProperty IsTextSelectionEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty LineHeightProperty
		{
			get;
		}
		public static extern DependencyProperty LineStackingStrategyProperty
		{
			get;
		}
		public static extern DependencyProperty PaddingProperty
		{
			get;
		}
		public static extern DependencyProperty SelectedTextProperty
		{
			get;
		}
		public static extern DependencyProperty TextAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty TextProperty
		{
			get;
		}
		public static extern DependencyProperty TextTrimmingProperty
		{
			get;
		}
		public static extern DependencyProperty TextWrappingProperty
		{
			get;
		}
		public extern TextBlock();
		public extern void SelectAll();
		public extern void Select([In] TextPointer start, [In] TextPointer end);
		public extern bool Focus([In] FocusState value);
	}
}
