using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class OpacityAnimation : IOpacityAnimation, IPropertyAnimation
	{
		public extern float FinalOpacity
		{
			get;
		}
		public extern IReference<float> InitialOpacity
		{
			get;
		}
		public extern Point Control1
		{
			get;
		}
		public extern Point Control2
		{
			get;
		}
		public extern TimeSpan Delay
		{
			get;
		}
		public extern TimeSpan Duration
		{
			get;
		}
		public extern PropertyAnimationType Type
		{
			get;
		}
	}
}
