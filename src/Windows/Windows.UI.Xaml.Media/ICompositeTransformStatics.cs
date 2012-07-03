using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(CompositeTransform)), Guid(790170632u, 33382, 18799, 150, 83, 161, 139, 212, 248, 54, 170), Version(100794368u), WebHostHidden]
	internal interface ICompositeTransformStatics
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
		DependencyProperty RotationProperty
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
		DependencyProperty SkewXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty SkewYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty TranslateXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty TranslateYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
	}
}
