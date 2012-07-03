using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(RotateTransform)), Guid(2704403338u, 20899, 16822, 185, 211, 161, 14, 66, 144, 84, 171), Version(100794368u), WebHostHidden]
	internal interface IRotateTransformStatics
	{
		DependencyProperty AngleProperty
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
