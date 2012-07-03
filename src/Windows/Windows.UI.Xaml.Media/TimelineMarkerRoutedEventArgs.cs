using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TimelineMarkerRoutedEventArgs : RoutedEventArgs, ITimelineMarkerRoutedEventArgs
	{
		public extern TimelineMarker Marker
		{
			get;
			set;
		}
		public extern TimelineMarkerRoutedEventArgs();
	}
}
