using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IEasingDoubleKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class EasingDoubleKeyFrame : DoubleKeyFrame, IEasingDoubleKeyFrame
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
		public extern EasingDoubleKeyFrame();
	}
}
