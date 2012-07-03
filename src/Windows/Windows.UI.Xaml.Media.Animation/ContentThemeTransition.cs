using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IContentThemeTransitionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ContentThemeTransition : Transition, IContentThemeTransition
	{
		public extern double HorizontalOffset
		{
			get;
			set;
		}
		public extern double VerticalOffset
		{
			get;
			set;
		}
		public static extern DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalOffsetProperty
		{
			get;
		}
		public extern ContentThemeTransition();
	}
}
