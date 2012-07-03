using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DoubleKeyFrame)), Guid(843465136u, 32055, 17018, 173, 235, 67, 243, 139, 182, 26, 77), Version(100794368u), WebHostHidden]
	internal interface IDoubleKeyFrameStatics
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
