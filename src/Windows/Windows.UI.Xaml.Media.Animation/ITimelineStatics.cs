using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(Timeline)), Guid(2835541326u, 61200, 19823, 154, 64, 147, 203, 136, 149, 244, 229), Version(100794368u), WebHostHidden]
	internal interface ITimelineStatics
	{
		bool AllowDependentAnimations
		{
			get;
			set;
		}
		DependencyProperty AutoReverseProperty
		{
			get;
		}
		DependencyProperty BeginTimeProperty
		{
			get;
		}
		DependencyProperty DurationProperty
		{
			get;
		}
		DependencyProperty FillBehaviorProperty
		{
			get;
		}
		DependencyProperty RepeatBehaviorProperty
		{
			get;
		}
		DependencyProperty SpeedRatioProperty
		{
			get;
		}
	}
}
