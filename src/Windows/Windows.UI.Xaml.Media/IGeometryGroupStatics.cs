using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GeometryGroup)), Guid(1456035316u, 33942, 19382, 171, 240, 97, 123, 31, 231, 139, 69), Version(100794368u), WebHostHidden]
	internal interface IGeometryGroupStatics
	{
		DependencyProperty ChildrenProperty
		{
			get;
		}
		DependencyProperty FillRuleProperty
		{
			get;
		}
	}
}
