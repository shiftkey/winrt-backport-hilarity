using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GeometryGroup)), Guid(1428314721u, 34423, 19596, 142, 70, 238, 61, 195, 85, 17, 75), Version(100794368u), WebHostHidden]
	internal interface IGeometryGroup
	{
		GeometryCollection Children
		{
			get;
			set;
		}
		FillRule FillRule
		{
			get;
			set;
		}
	}
}
