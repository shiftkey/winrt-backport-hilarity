using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ColorAnimationUsingKeyFrames)), Guid(4123534912u, 5059, 17066, 154, 226, 126, 107, 81, 201, 47, 149), Version(100794368u), WebHostHidden]
	internal interface IColorAnimationUsingKeyFrames
	{
		bool EnableDependentAnimation
		{
			get;
			set;
		}
		ColorKeyFrameCollection KeyFrames
		{
			get;
		}
	}
}
