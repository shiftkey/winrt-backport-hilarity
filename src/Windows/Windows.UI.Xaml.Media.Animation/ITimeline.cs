using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(Timeline)), Guid(197420508u, 48717, 19725, 149, 73, 34, 8, 183, 21, 244, 13), Version(100794368u), WebHostHidden]
	internal interface ITimeline
	{
		event EventHandler<object> Completed;
		bool AutoReverse
		{
			get;
			set;
		}
		IReference<TimeSpan> BeginTime
		{
			get;
			set;
		}
		Duration Duration
		{
			get;
			set;
		}
		FillBehavior FillBehavior
		{
			get;
			set;
		}
		RepeatBehavior RepeatBehavior
		{
			get;
			set;
		}
		double SpeedRatio
		{
			get;
			set;
		}
	}
}
