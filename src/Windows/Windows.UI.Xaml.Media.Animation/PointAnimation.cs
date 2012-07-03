using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPointAnimationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PointAnimation : Timeline, IPointAnimation
	{
		public extern IReference<Point> By
		{
			get;
			set;
		}
		public extern EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
		public extern bool EnableDependentAnimation
		{
			get;
			set;
		}
		public extern IReference<Point> From
		{
			get;
			set;
		}
		public extern IReference<Point> To
		{
			get;
			set;
		}
		public static extern DependencyProperty ByProperty
		{
			get;
		}
		public static extern DependencyProperty EasingFunctionProperty
		{
			get;
		}
		public static extern DependencyProperty EnableDependentAnimationProperty
		{
			get;
		}
		public static extern DependencyProperty FromProperty
		{
			get;
		}
		public static extern DependencyProperty ToProperty
		{
			get;
		}
		public extern PointAnimation();
	}
}
