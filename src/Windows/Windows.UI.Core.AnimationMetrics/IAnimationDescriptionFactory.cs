using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[ExclusiveTo(typeof(AnimationDescription)), Guid(3336731326u, 49659, 18613, 146, 113, 236, 199, 10, 200, 110, 240), Version(100794368u)]
	internal interface IAnimationDescriptionFactory
	{
		AnimationDescription CreateInstance([In] AnimationEffect effect, [In] AnimationEffectTarget target);
	}
}
