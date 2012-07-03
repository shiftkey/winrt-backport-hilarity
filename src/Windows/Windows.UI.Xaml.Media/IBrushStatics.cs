using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Brush)), Guid(3876335874u, 549, 18421, 178, 46, 4, 103, 97, 159, 106, 34), Version(100794368u), WebHostHidden]
	internal interface IBrushStatics
	{
		DependencyProperty OpacityProperty
		{
			get;
		}
		DependencyProperty RelativeTransformProperty
		{
			get;
		}
		DependencyProperty TransformProperty
		{
			get;
		}
	}
}
