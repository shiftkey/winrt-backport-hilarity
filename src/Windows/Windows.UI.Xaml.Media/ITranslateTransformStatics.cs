using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TranslateTransform)), Guid(4095322769u, 57410, 16657, 156, 47, 210, 1, 48, 65, 35, 221), Version(100794368u), WebHostHidden]
	internal interface ITranslateTransformStatics
	{
		DependencyProperty XProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty YProperty
		{
			[IndependentlyAnimatable]
			get;
		}
	}
}
