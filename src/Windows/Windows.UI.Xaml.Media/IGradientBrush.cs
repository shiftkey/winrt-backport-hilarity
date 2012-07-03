using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GradientBrush)), Guid(560391839u, 37722, 16785, 142, 60, 28, 141, 253, 252, 220, 120), Version(100794368u), WebHostHidden]
	internal interface IGradientBrush
	{
		ColorInterpolationMode ColorInterpolationMode
		{
			get;
			set;
		}
		GradientStopCollection GradientStops
		{
			get;
			set;
		}
		BrushMappingMode MappingMode
		{
			get;
			set;
		}
		GradientSpreadMethod SpreadMethod
		{
			get;
			set;
		}
	}
}
