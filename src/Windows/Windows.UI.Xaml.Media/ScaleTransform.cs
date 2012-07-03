using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IScaleTransformStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScaleTransform : Transform, IScaleTransform
	{
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
		public extern double ScaleX
		{
			get;
			set;
		}
		public extern double ScaleY
		{
			get;
			set;
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
		public static extern DependencyProperty ScaleXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty ScaleYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public extern ScaleTransform();
	}
}
