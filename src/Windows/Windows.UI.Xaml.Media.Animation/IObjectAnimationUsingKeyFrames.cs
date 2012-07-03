using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ObjectAnimationUsingKeyFrames)), Guid(860499346u, 46922, 19556, 185, 166, 88, 188, 250, 49, 79, 34), Version(100794368u), WebHostHidden]
	internal interface IObjectAnimationUsingKeyFrames
	{
		bool EnableDependentAnimation
		{
			get;
			set;
		}
		ObjectKeyFrameCollection KeyFrames
		{
			get;
		}
	}
}
