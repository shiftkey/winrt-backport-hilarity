using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DoubleAnimationUsingKeyFrames)), Guid(1341022863u, 49134, 20341, 131, 194, 169, 59, 57, 72, 132, 115), Version(100794368u), WebHostHidden]
	internal interface IDoubleAnimationUsingKeyFrames
	{
		bool EnableDependentAnimation
		{
			get;
			set;
		}
		DoubleKeyFrameCollection KeyFrames
		{
			get;
		}
	}
}
