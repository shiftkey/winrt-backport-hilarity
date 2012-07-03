using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PolyQuadraticBezierSegment)), Guid(3713854845u, 59099, 19606, 182, 161, 63, 206, 150, 233, 135, 166), Version(100794368u), WebHostHidden]
	internal interface IPolyQuadraticBezierSegment
	{
		PointCollection Points
		{
			get;
			set;
		}
	}
}
