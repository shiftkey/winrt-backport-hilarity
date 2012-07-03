using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Composable(typeof(IPointKeyFrameFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPointKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class PointKeyFrame : DependencyObject, IPointKeyFrame
	{
		public extern KeyTime KeyTime
		{
			get;
			set;
		}
		public extern Point Value
		{
			get;
			set;
		}
		public static extern DependencyProperty KeyTimeProperty
		{
			get;
		}
		public static extern DependencyProperty ValueProperty
		{
			get;
		}
		protected extern PointKeyFrame();
	}
}
