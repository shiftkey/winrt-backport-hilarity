using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Composable(typeof(IObjectKeyFrameFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IObjectKeyFrameStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ObjectKeyFrame : DependencyObject, IObjectKeyFrame
	{
		public extern KeyTime KeyTime
		{
			get;
			set;
		}
		public extern object Value
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
		protected extern ObjectKeyFrame();
	}
}
