using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IEasingColorKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class EasingColorKeyFrame : ColorKeyFrame, IEasingColorKeyFrame
	{
		public extern EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
		public static extern DependencyProperty EasingFunctionProperty
		{
			get;
		}
		public extern EasingColorKeyFrame();
	}
}
