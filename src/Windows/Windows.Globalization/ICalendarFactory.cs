using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(Calendar)), Guid(2213905426u, 58731, 19573, 166, 110, 15, 99, 213, 119, 88, 166), Version(100794368u)]
	internal interface ICalendarFactory
	{
		Calendar CreateCalendarDefaultCalendarAndClock([In] IIterable<string> languages);
		Calendar CreateCalendar([In] IIterable<string> languages, [In] string calendar, [In] string clock);
	}
}
