using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Documents
{
	[Composable(typeof(ITextElementFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITextElementStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class TextElement : DependencyObject, ITextElement, ITextElementOverrides
	{
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
		public extern TextPointer ElementEnd
		{
			get;
		}
		public extern TextPointer ElementStart
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
		public extern string Language
		{
			get;
			set;
		}
		public extern string Name
		{
			get;
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
		public static extern DependencyProperty LanguageProperty
		{
			get;
		}
		public extern object FindName([In] string name);
		protected virtual extern void OnDisconnectVisualChildren();
	}
}
