using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Composable(typeof(IColorKeyFrameFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IColorKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ColorKeyFrame : DependencyObject, IColorKeyFrame
	{
		public extern KeyTime KeyTime
		{
			get;
			set;
		}
		public extern Color Value
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
		protected extern ColorKeyFrame();
	}
}
