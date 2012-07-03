using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(ScaleTransform)), Guid(2643736308u, 16551, 18141, 151, 90, 7, 211, 55, 205, 133, 46), Version(100794368u), WebHostHidden]
	internal interface IScaleTransformStatics
	{
		DependencyProperty CenterXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty CenterYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty ScaleXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty ScaleYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
	}
}
