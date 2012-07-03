using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPointAnimationUsingKeyFramesStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "KeyFrames")]
	public sealed class PointAnimationUsingKeyFrames : Timeline, IPointAnimationUsingKeyFrames
	{
		public extern bool EnableDependentAnimation
		{
			get;
			set;
		}
		public extern PointKeyFrameCollection KeyFrames
		{
			get;
		}
		public static extern DependencyProperty EnableDependentAnimationProperty
		{
			get;
		}
		public extern PointAnimationUsingKeyFrames();
	}
}
