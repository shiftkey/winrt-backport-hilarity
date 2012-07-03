using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RangeBase)), Guid(4194315290u, 18766, 18127, 145, 212, 225, 74, 141, 121, 134, 117), Version(100794368u), WebHostHidden]
	internal interface IRangeBase
	{
		event RangeBaseValueChangedEventHandler ValueChanged;
		double LargeChange
		{
			get;
			set;
		}
		double Maximum
		{
			get;
			set;
		}
		double Minimum
		{
			get;
			set;
		}
		double SmallChange
		{
			get;
			set;
		}
		double Value
		{
			get;
			set;
		}
	}
}
