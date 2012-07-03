using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(WrapGrid)), Guid(3494538135u, 5067, 18332, 162, 133, 228, 229, 104, 70, 196, 203), Version(100794368u), WebHostHidden]
	internal interface IWrapGridStatics
	{
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
		DependencyProperty VerticalChildrenAlignmentProperty
		{
			get;
		}
	}
}
