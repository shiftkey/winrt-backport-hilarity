using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(WrapGrid)), Guid(89266059u, 30055, 18370, 189, 92, 173, 131, 148, 200, 40, 186), Version(100794368u), WebHostHidden]
	internal interface IWrapGrid
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
