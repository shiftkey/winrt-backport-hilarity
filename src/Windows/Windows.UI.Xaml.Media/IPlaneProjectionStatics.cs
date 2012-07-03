using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PlaneProjection)), Guid(2912001127u, 15324, 18517, 137, 105, 209, 249, 163, 173, 194, 125), Version(100794368u), WebHostHidden]
	internal interface IPlaneProjectionStatics
	{
		DependencyProperty CenterOfRotationXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty CenterOfRotationYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty CenterOfRotationZProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty GlobalOffsetXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty GlobalOffsetYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty GlobalOffsetZProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty LocalOffsetXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty LocalOffsetYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty LocalOffsetZProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty ProjectionMatrixProperty
		{
			get;
		}
		DependencyProperty RotationXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty RotationYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty RotationZProperty
		{
			[IndependentlyAnimatable]
			get;
		}
	}
}
