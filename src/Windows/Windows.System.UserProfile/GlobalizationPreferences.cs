using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
namespace Windows.System.UserProfile
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGlobalizationPreferencesStatics), 100794368u), Version(100794368u)]
	public static class GlobalizationPreferences
	{
		public static extern IVectorView<string> Calendars
		{
			get;
		}
		public static extern IVectorView<string> Clocks
		{
			get;
		}
		public static extern IVectorView<string> Currencies
		{
			get;
		}
		public static extern string HomeGeographicRegion
		{
			get;
		}
		public static extern IVectorView<string> Languages
		{
			get;
		}
		public static extern DayOfWeek WeekStartsOn
		{
			get;
		}
	}
}
