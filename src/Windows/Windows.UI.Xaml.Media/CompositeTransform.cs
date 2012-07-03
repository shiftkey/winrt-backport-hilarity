using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICompositeTransformStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class CompositeTransform : Transform, ICompositeTransform
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
		public extern double Rotation
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
		public extern double SkewX
		{
			get;
			set;
		}
		public extern double SkewY
		{
			get;
			set;
		}
		public extern double TranslateX
		{
			get;
			set;
		}
		public extern double TranslateY
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
		public static extern DependencyProperty RotationProperty
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
		public static extern DependencyProperty SkewXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty SkewYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty TranslateXProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty TranslateYProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public extern CompositeTransform();
	}
}
