using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[ExclusiveTo(typeof(ScaleAnimation)), Guid(37049031u, 29099, 17036, 156, 159, 211, 23, 128, 150, 73, 149), Version(100794368u)]
	internal interface IScaleAnimation : IPropertyAnimation
	{
		float FinalScaleX
		{
			get;
		}
		float FinalScaleY
		{
			get;
		}
		IReference<float> InitialScaleX
		{
			get;
		}
		IReference<float> InitialScaleY
		{
			get;
		}
		Point NormalizedOrigin
		{
			get;
		}
	}
}
