using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Rectangle)), Guid(2670045779u, 47930, 19516, 137, 219, 111, 188, 13, 31, 160, 204), Version(100794368u), WebHostHidden]
	internal interface IRectangleStatics
	{
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
