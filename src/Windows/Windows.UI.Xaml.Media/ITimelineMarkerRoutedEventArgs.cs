using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TimelineMarkerRoutedEventArgs)), Guid(2084257523u, 11400, 19868, 153, 182, 70, 205, 189, 72, 212, 193), Version(100794368u), WebHostHidden]
	internal interface ITimelineMarkerRoutedEventArgs
	{
		TimelineMarker Marker
		{
			get;
			set;
		}
	}
}
