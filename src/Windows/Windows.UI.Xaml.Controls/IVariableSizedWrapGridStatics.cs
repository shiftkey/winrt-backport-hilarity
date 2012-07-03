using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VariableSizedWrapGrid)), Guid(4271749209u, 33063, 19183, 183, 162, 148, 152, 71, 72, 110, 150), Version(100794368u), WebHostHidden]
	internal interface IVariableSizedWrapGridStatics
	{
		DependencyProperty ColumnSpanProperty
		{
			get;
		}
		DependencyProperty HorizontalChildrenAlignmentProperty
		{
			get;
		}
		DependencyProperty ItemHeightProperty
		{
			get;
		}
		DependencyProperty ItemWidthProperty
		{
			get;
		}
		DependencyProperty MaximumRowsOrColumnsProperty
		{
			get;
		}
		DependencyProperty OrientationProperty
		{
			get;
		}
		DependencyProperty RowSpanProperty
		{
			get;
		}
		DependencyProperty VerticalChildrenAlignmentProperty
		{
			get;
		}
		int GetRowSpan([In] UIElement element);
		void SetRowSpan([In] UIElement element, [In] int value);
		int GetColumnSpan([In] UIElement element);
		void SetColumnSpan([In] UIElement element, [In] int value);
	}
}
