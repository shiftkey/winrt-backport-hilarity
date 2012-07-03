using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RepeatButton)), Guid(957656142u, 62562, 20339, 129, 151, 232, 132, 102, 57, 198, 130), Version(100794368u), WebHostHidden]
	internal interface IRepeatButtonStatics
	{
		DependencyProperty DelayProperty
		{
			get;
		}
		DependencyProperty IntervalProperty
		{
			get;
		}
	}
}
