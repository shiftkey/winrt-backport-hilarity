using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(BezierSegment)), Guid(2940975598u, 35204, 18871, 129, 223, 63, 53, 153, 75, 149, 235), Version(100794368u), WebHostHidden]
	internal interface IBezierSegment
	{
		Point Point1
		{
			get;
			set;
		}
		Point Point2
		{
			get;
			set;
		}
		Point Point3
		{
			get;
			set;
		}
	}
}
