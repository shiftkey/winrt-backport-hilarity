using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GradientBrush)), Guid(2518049273u, 35764, 20076, 185, 35, 181, 215, 135, 224, 241, 169), Version(100794368u), WebHostHidden]
	internal interface IGradientBrushStatics
	{
		DependencyProperty ColorInterpolationModeProperty
		{
			get;
		}
		DependencyProperty GradientStopsProperty
		{
			get;
		}
		DependencyProperty MappingModeProperty
		{
			get;
		}
		DependencyProperty SpreadMethodProperty
		{
			get;
		}
	}
}
