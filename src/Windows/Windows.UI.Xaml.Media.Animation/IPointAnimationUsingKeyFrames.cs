using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointAnimationUsingKeyFrames)), Guid(2610188146u, 17514, 16848, 161, 41, 65, 166, 32, 244, 89, 93), Version(100794368u), WebHostHidden]
	internal interface IPointAnimationUsingKeyFrames
	{
		bool EnableDependentAnimation
		{
			get;
			set;
		}
		PointKeyFrameCollection KeyFrames
		{
			get;
		}
	}
}
