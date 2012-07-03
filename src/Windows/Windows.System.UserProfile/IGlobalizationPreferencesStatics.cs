using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
namespace Windows.System.UserProfile
{
	[ExclusiveTo(typeof(GlobalizationPreferences)), Guid(29311782u, 60727, 20118, 176, 233, 193, 52, 13, 30, 161, 88), Version(100794368u)]
	internal interface IGlobalizationPreferencesStatics
	{
		IVectorView<string> Calendars
		{
			get;
		}
		IVectorView<string> Clocks
		{
			get;
		}
		IVectorView<string> Currencies
		{
			get;
		}
		string HomeGeographicRegion
		{
			get;
		}
		IVectorView<string> Languages
		{
			get;
		}
		DayOfWeek WeekStartsOn
		{
			get;
		}
	}
}
