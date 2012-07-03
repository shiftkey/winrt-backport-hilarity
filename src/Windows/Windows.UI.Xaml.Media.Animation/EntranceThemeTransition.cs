using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IEntranceThemeTransitionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class EntranceThemeTransition : Transition, IEntranceThemeTransition
	{
		public extern double FromHorizontalOffset
		{
			get;
			set;
		}
		public extern double FromVerticalOffset
		{
			get;
			set;
		}
		public extern bool IsStaggeringEnabled
		{
			get;
			set;
		}
		public static extern DependencyProperty FromHorizontalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty FromVerticalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty IsStaggeringEnabledProperty
		{
			get;
		}
		public extern EntranceThemeTransition();
	}
}
