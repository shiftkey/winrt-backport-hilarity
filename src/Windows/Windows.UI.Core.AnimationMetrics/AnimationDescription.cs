using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[Activatable(typeof(IAnimationDescriptionFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class AnimationDescription : IAnimationDescription
	{
		public extern IVectorView<IPropertyAnimation> Animations
		{
			get;
		}
		public extern TimeSpan DelayLimit
		{
			get;
		}
		public extern TimeSpan StaggerDelay
		{
			get;
		}
		public extern float StaggerDelayFactor
		{
			get;
		}
		public extern int ZOrder
		{
			get;
		}
		public extern AnimationDescription([In] AnimationEffect effect, [In] AnimationEffectTarget target);
	}
}
