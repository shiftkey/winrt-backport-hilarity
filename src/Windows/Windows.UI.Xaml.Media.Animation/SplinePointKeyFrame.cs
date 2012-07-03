using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISplinePointKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SplinePointKeyFrame : PointKeyFrame, ISplinePointKeyFrame
	{
		public extern KeySpline KeySpline
		{
			get;
			set;
		}
		public static extern DependencyProperty KeySplineProperty
		{
			get;
		}
		public extern SplinePointKeyFrame();
	}
}
