using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRotateTransformStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RotateTransform : Transform, IRotateTransform
	{
		public extern double Angle
		{
			get;
			set;
		}
		public extern double CenterX
		{
			get;
			set;
		}
		public extern double CenterY
		{
			get;
			set;
		}
		public static extern DependencyProperty AngleProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty CenterXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty CenterYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public extern RotateTransform();
	}
}
