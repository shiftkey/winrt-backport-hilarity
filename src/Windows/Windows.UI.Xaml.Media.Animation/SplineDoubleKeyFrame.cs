using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISplineDoubleKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SplineDoubleKeyFrame : DoubleKeyFrame, ISplineDoubleKeyFrame
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
		public extern SplineDoubleKeyFrame();
	}
}
