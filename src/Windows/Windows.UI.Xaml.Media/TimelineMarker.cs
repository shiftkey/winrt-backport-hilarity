using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITimelineMarkerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TimelineMarker : DependencyObject, ITimelineMarker
	{
		public extern string Text
		{
			get;
			set;
		}
		public extern TimeSpan Time
		{
			get;
			set;
		}
		public extern string Type
		{
			get;
			set;
		}
		public static extern DependencyProperty TextProperty
		{
			get;
		}
		public static extern DependencyProperty TimeProperty
		{
			get;
		}
		public static extern DependencyProperty TypeProperty
		{
			get;
		}
		public extern TimelineMarker();
	}
}
