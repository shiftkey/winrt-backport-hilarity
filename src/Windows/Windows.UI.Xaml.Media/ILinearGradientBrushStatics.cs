using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(LinearGradientBrush)), Guid(2063000836u, 11715, 16611, 190, 11, 179, 20, 193, 60, 185, 145), Version(100794368u), WebHostHidden]
	internal interface ILinearGradientBrushStatics
	{
		DependencyProperty EndPointProperty
		{
			get;
		}
		DependencyProperty StartPointProperty
		{
			get;
		}
	}
}
