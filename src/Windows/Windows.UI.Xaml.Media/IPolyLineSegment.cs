using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PolyLineSegment)), Guid(1262059399u, 41702, 18333, 189, 200, 111, 68, 100, 100, 104, 135), Version(100794368u), WebHostHidden]
	internal interface IPolyLineSegment
	{
		PointCollection Points
		{
			get;
			set;
		}
	}
}
