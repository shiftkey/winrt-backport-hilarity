using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TextPointer : ITextPointer
	{
		public extern LogicalDirection LogicalDirection
		{
			get;
		}
		public extern int Offset
		{
			get;
		}
		public extern DependencyObject Parent
		{
			get;
		}
		public extern FrameworkElement VisualParent
		{
			get;
		}
		public extern Rect GetCharacterRect([In] LogicalDirection direction);
		public extern TextPointer GetPositionAtOffset([In] int offset, [In] LogicalDirection direction);
	}
}
