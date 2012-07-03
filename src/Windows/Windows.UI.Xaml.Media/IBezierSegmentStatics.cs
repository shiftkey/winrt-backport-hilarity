using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(BezierSegment)), Guid(3223878572u, 5136, 17712, 132, 82, 28, 157, 10, 209, 243, 65), Version(100794368u), WebHostHidden]
	internal interface IBezierSegmentStatics
	{
		DependencyProperty Point1Property
		{
			get;
		}
		DependencyProperty Point2Property
		{
			get;
		}
		DependencyProperty Point3Property
		{
			get;
		}
	}
}
