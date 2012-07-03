using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PathGeometry)), Guid(3655699386u, 11450, 18241, 143, 141, 49, 152, 207, 81, 134, 185), Version(100794368u), WebHostHidden]
	internal interface IPathGeometryStatics
	{
		DependencyProperty FiguresProperty
		{
			get;
		}
		DependencyProperty FillRuleProperty
		{
			get;
		}
	}
}
