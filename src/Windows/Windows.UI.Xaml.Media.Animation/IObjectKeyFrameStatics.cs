using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ObjectKeyFrame)), Guid(752265984u, 21273, 17030, 142, 237, 78, 117, 94, 160, 207, 156), Version(100794368u), WebHostHidden]
	internal interface IObjectKeyFrameStatics
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
