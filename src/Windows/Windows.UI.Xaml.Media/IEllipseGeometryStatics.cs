using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(EllipseGeometry)), Guid(390388551u, 63029, 19222, 174, 230, 224, 82, 166, 93, 239, 178), Version(100794368u), WebHostHidden]
	internal interface IEllipseGeometryStatics
	{
		DependencyProperty CenterProperty
		{
			get;
		}
		DependencyProperty RadiusXProperty
		{
			get;
		}
		DependencyProperty RadiusYProperty
		{
			get;
		}
	}
}
