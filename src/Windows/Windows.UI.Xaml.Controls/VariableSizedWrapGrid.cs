using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IVariableSizedWrapGridStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class VariableSizedWrapGrid : Panel, IVariableSizedWrapGrid
	{
		public extern HorizontalAlignment HorizontalChildrenAlignment
		{
			get;
			set;
		}
		public extern double ItemHeight
		{
			get;
			set;
		}
		public extern double ItemWidth
		{
			get;
			set;
		}
		public extern int MaximumRowsOrColumns
		{
			get;
			set;
		}
		public extern Orientation Orientation
		{
			get;
			set;
		}
		public extern VerticalAlignment VerticalChildrenAlignment
		{
			get;
			set;
		}
		public static extern DependencyProperty ColumnSpanProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalChildrenAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty ItemHeightProperty
		{
			get;
		}
		public static extern DependencyProperty ItemWidthProperty
		{
			get;
		}
		public static extern DependencyProperty MaximumRowsOrColumnsProperty
		{
			get;
		}
		public static extern DependencyProperty OrientationProperty
		{
			get;
		}
		public static extern DependencyProperty RowSpanProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalChildrenAlignmentProperty
		{
			get;
		}
		public extern VariableSizedWrapGrid();
		public static extern int GetRowSpan([In] UIElement element);
		public static extern void SetRowSpan([In] UIElement element, [In] int value);
		public static extern int GetColumnSpan([In] UIElement element);
		public static extern void SetColumnSpan([In] UIElement element, [In] int value);
	}
}
