using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRepeatButtonStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RepeatButton : ButtonBase, IRepeatButton
	{
		public extern int Delay
		{
			get;
			set;
		}
		public extern int Interval
		{
			get;
			set;
		}
		public static extern DependencyProperty DelayProperty
		{
			get;
		}
		public static extern DependencyProperty IntervalProperty
		{
			get;
		}
		public extern RepeatButton();
	}
}
