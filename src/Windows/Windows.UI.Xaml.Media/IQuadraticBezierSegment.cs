using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(QuadraticBezierSegment)), Guid(743479899u, 48920, 17754, 160, 120, 145, 75, 82, 50, 216, 175), Version(100794368u), WebHostHidden]
	internal interface IQuadraticBezierSegment
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
	}
}
