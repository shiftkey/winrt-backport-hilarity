using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PolyLineSegment)), Guid(3595185287u, 13297, 20080, 164, 127, 180, 152, 30, 246, 72, 162), Version(100794368u), WebHostHidden]
	internal interface IPolyLineSegmentStatics
	{
		DependencyProperty PointsProperty
		{
			get;
		}
	}
}
