using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRichTextBlockOverflowStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RichTextBlockOverflow : FrameworkElement, IRichTextBlockOverflow
	{
		public extern double BaselineOffset
		{
			get;
		}
		public extern TextPointer ContentEnd
		{
			get;
		}
		public extern RichTextBlock ContentSource
		{
			get;
		}
		public extern TextPointer ContentStart
		{
			get;
		}
		public extern bool HasOverflowContent
		{
			get;
		}
		public extern RichTextBlockOverflow OverflowContentTarget
		{
			get;
			set;
		}
		public extern Thickness Padding
		{
			get;
			set;
		}
		public static extern DependencyProperty HasOverflowContentProperty
		{
			get;
		}
		public static extern DependencyProperty OverflowContentTargetProperty
		{
			get;
		}
		public static extern DependencyProperty PaddingProperty
		{
			get;
		}
		public extern RichTextBlockOverflow();
		public extern TextPointer GetPositionFromPoint([In] Point point);
		public extern bool Focus([In] FocusState value);
	}
}
