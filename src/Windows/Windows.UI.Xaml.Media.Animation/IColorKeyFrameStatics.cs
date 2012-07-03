using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ColorKeyFrame)), Guid(3225661081u, 8460, 17167, 157, 165, 223, 16, 130, 105, 32, 85), Version(100794368u), WebHostHidden]
	internal interface IColorKeyFrameStatics
	{
		DependencyProperty KeyTimeProperty
		{
			get;
		}
		DependencyProperty ValueProperty
		{
			get;
		}
	}
}
