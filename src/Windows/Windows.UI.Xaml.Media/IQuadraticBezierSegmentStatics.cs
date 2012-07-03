using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(QuadraticBezierSegment)), Guid(1774682744u, 15371, 19279, 183, 162, 240, 3, 222, 212, 27, 176), Version(100794368u), WebHostHidden]
	internal interface IQuadraticBezierSegmentStatics
	{
		DependencyProperty Point1Property
		{
			get;
		}
		DependencyProperty Point2Property
		{
			get;
		}
	}
}
