using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Polyline)), Guid(3349818577u, 41580, 17328, 170, 165, 130, 47, 166, 74, 17, 185), Version(100794368u), WebHostHidden]
	internal interface IPolylineStatics
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
