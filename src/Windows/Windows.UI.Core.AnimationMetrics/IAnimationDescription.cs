using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[ExclusiveTo(typeof(AnimationDescription)), Guid(2098308425u, 48701, 16862, 176, 129, 5, 193, 73, 150, 47, 155), Version(100794368u)]
	internal interface IAnimationDescription
	{
		IVectorView<IPropertyAnimation> Animations
		{
			get;
		}
		TimeSpan DelayLimit
		{
			get;
		}
		TimeSpan StaggerDelay
		{
			get;
		}
		float StaggerDelayFactor
		{
			get;
		}
		int ZOrder
		{
			get;
		}
	}
}
