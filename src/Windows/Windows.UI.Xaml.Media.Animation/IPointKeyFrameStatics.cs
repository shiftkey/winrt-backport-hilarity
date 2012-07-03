using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointKeyFrame)), Guid(2513378087u, 31077, 19436, 185, 251, 251, 233, 75, 101, 81, 142), Version(100794368u), WebHostHidden]
	internal interface IPointKeyFrameStatics
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
