using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Polygon)), Guid(908757675u, 54371, 17254, 158, 26, 190, 186, 114, 129, 15, 183), Version(100794368u), WebHostHidden]
	internal interface IPolygonStatics
	{
		DependencyProperty FillRuleProperty
		{
			get;
		}
		DependencyProperty PointsProperty
		{
			get;
		}
	}
}
