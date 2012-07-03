using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Composable(typeof(ITimelineFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITimelineStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Timeline : DependencyObject, ITimeline
	{
		public extern event EventHandler<object> Completed
		{
			add;
			remove;
		}
		public extern bool AutoReverse
		{
			get;
			set;
		}
		public extern IReference<TimeSpan> BeginTime
		{
			get;
			set;
		}
		public extern Duration Duration
		{
			get;
			set;
		}
		public extern FillBehavior FillBehavior
		{
			get;
			set;
		}
		public extern RepeatBehavior RepeatBehavior
		{
			get;
			set;
		}
		public extern double SpeedRatio
		{
			get;
			set;
		}
		public static extern bool AllowDependentAnimations
		{
			get;
			set;
		}
		public static extern DependencyProperty AutoReverseProperty
		{
			get;
		}
		public static extern DependencyProperty BeginTimeProperty
		{
			get;
		}
		public static extern DependencyProperty DurationProperty
		{
			get;
		}
		public static extern DependencyProperty FillBehaviorProperty
		{
			get;
		}
		public static extern DependencyProperty RepeatBehaviorProperty
		{
			get;
		}
		public static extern DependencyProperty SpeedRatioProperty
		{
			get;
		}
		protected extern Timeline();
	}
}
