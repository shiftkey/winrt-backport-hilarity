using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(ArcSegment)), Guid(2184482670u, 35433, 16900, 156, 18, 114, 7, 223, 49, 118, 67), Version(100794368u), WebHostHidden]
	internal interface IArcSegmentStatics
	{
		DependencyProperty IsLargeArcProperty
		{
			get;
		}
		DependencyProperty PointProperty
		{
			get;
		}
		DependencyProperty RotationAngleProperty
		{
			get;
		}
		DependencyProperty SizeProperty
		{
			get;
		}
		DependencyProperty SweepDirectionProperty
		{
			get;
		}
	}
}
