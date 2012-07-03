using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TimelineMarker)), Guid(2794385453u, 17850, 20048, 140, 173, 170, 234, 58, 34, 122, 245), Version(100794368u), WebHostHidden]
	internal interface ITimelineMarker
	{
		string Text
		{
			get;
			set;
		}
		TimeSpan Time
		{
			get;
			set;
		}
		string Type
		{
			get;
			set;
		}
	}
}
