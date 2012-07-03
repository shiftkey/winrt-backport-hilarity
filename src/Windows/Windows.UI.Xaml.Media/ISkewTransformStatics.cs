using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(SkewTransform)), Guid(3973127539u, 22036, 19249, 182, 175, 190, 174, 16, 16, 86, 36), Version(100794368u), WebHostHidden]
	internal interface ISkewTransformStatics
	{
		DependencyProperty AngleXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty AngleYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
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
	}
}
