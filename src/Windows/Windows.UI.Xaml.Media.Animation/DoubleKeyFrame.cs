using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Composable(typeof(IDoubleKeyFrameFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDoubleKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DoubleKeyFrame : DependencyObject, IDoubleKeyFrame
	{
		public extern KeyTime KeyTime
		{
			get;
			set;
		}
		public extern double Value
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
		protected extern DoubleKeyFrame();
	}
}
