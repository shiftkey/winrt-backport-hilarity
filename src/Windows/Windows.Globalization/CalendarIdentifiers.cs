using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICalendarIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class CalendarIdentifiers
	{
		public static extern string Gregorian
		{
			get;
		}
		public static extern string Hebrew
		{
			get;
		}
		public static extern string Hijri
		{
			get;
		}
		public static extern string Japanese
		{
			get;
		}
		public static extern string Julian
		{
			get;
		}
		public static extern string Korean
		{
			get;
		}
		public static extern string Taiwan
		{
			get;
		}
		public static extern string Thai
		{
			get;
		}
		public static extern string UmAlQura
		{
			get;
		}
	}
}
