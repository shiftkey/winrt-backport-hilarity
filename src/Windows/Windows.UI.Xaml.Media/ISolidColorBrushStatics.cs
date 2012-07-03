using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(SolidColorBrush)), Guid(3785776890u, 11043, 16826, 185, 186, 112, 148, 236, 142, 78, 159), Version(100794368u), WebHostHidden]
	internal interface ISolidColorBrushStatics
	{
		DependencyProperty ColorProperty
		{
			[IndependentlyAnimatable]
			get;
		}
	}
}
