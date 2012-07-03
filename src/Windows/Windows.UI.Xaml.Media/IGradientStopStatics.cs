using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GradientStop)), Guid(1613393269u, 24979, 20453, 142, 130, 199, 198, 246, 254, 186, 253), Version(100794368u), WebHostHidden]
	internal interface IGradientStopStatics
	{
		DependencyProperty ColorProperty
		{
			get;
		}
		DependencyProperty OffsetProperty
		{
			get;
		}
	}
}
