using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TimelineMarker)), Guid(3299799238u, 5795, 18507, 135, 245, 101, 40, 184, 240, 74, 71), Version(100794368u), WebHostHidden]
	internal interface ITimelineMarkerStatics
	{
		DependencyProperty TextProperty
		{
			get;
		}
		DependencyProperty TimeProperty
		{
			get;
		}
		DependencyProperty TypeProperty
		{
			get;
		}
	}
}
