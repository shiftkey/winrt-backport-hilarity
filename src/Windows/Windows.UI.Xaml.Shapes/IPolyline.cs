using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Polyline)), Guid(2447139576u, 17075, 18419, 132, 118, 197, 81, 36, 167, 196, 198), Version(100794368u), WebHostHidden]
	internal interface IPolyline
	{
		FillRule FillRule
		{
			get;
			set;
		}
		PointCollection Points
		{
			get;
			set;
		}
	}
}
