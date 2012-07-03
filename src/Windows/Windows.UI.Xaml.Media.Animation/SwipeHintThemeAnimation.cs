using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISwipeHintThemeAnimationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SwipeHintThemeAnimation : Timeline, ISwipeHintThemeAnimation
	{
		public extern string TargetName
		{
			get;
			set;
		}
		public extern double ToHorizontalOffset
		{
			get;
			set;
		}
		public extern double ToVerticalOffset
		{
			get;
			set;
		}
		public static extern DependencyProperty TargetNameProperty
		{
			get;
		}
		public static extern DependencyProperty ToHorizontalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty ToVerticalOffsetProperty
		{
			get;
		}
		public extern SwipeHintThemeAnimation();
	}
}
