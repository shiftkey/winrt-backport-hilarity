using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VariableSizedWrapGrid)), Guid(2628061127u, 9161, 20225, 184, 15, 190, 92, 33, 238, 244, 116), Version(100794368u), WebHostHidden]
	internal interface IVariableSizedWrapGrid
	{
		HorizontalAlignment HorizontalChildrenAlignment
		{
			get;
			set;
		}
		double ItemHeight
		{
			get;
			set;
		}
		double ItemWidth
		{
			get;
			set;
		}
		int MaximumRowsOrColumns
		{
			get;
			set;
		}
		Orientation Orientation
		{
			get;
			set;
		}
		VerticalAlignment VerticalChildrenAlignment
		{
			get;
			set;
		}
	}
}
