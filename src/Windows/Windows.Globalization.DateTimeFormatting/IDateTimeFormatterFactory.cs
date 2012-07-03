using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.DateTimeFormatting
{
	[ExclusiveTo(typeof(DateTimeFormatter)), Guid(3968698963u, 6702, 16685, 136, 21, 59, 116, 95, 177, 162, 160), Version(100794368u)]
	internal interface IDateTimeFormatterFactory
	{
		DateTimeFormatter CreateDateTimeFormatter([In] string formatTemplate);
		DateTimeFormatter CreateDateTimeFormatterLanguages([In] string formatTemplate, [In] IIterable<string> languages);
		DateTimeFormatter CreateDateTimeFormatterContext([In] string formatTemplate, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
		DateTimeFormatter CreateDateTimeFormatterDate([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat);
		DateTimeFormatter CreateDateTimeFormatterTime([In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat);
		DateTimeFormatter CreateDateTimeFormatterDateTimeLanguages([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages);
		DateTimeFormatter CreateDateTimeFormatterDateTimeContext([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
	}
}
