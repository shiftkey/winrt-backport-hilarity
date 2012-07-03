using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Polygon)), Guid(3816119321u, 11853, 19404, 141, 52, 134, 135, 25, 87, 250, 1), Version(100794368u), WebHostHidden]
	internal interface IPolygon
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
