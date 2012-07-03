using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IWrapGridStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WrapGrid : OrientedVirtualizingPanel, IWrapGrid
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
		public static extern DependencyProperty VerticalChildrenAlignmentProperty
		{
			get;
		}
		public extern WrapGrid();
	}
}
