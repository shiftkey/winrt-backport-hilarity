using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IObjectAnimationUsingKeyFramesStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "KeyFrames")]
	public sealed class ObjectAnimationUsingKeyFrames : Timeline, IObjectAnimationUsingKeyFrames
	{
		public extern bool EnableDependentAnimation
		{
			get;
			set;
		}
		public extern ObjectKeyFrameCollection KeyFrames
		{
			get;
		}
		public static extern DependencyProperty EnableDependentAnimationProperty
		{
			get;
		}
		public extern ObjectAnimationUsingKeyFrames();
	}
}
