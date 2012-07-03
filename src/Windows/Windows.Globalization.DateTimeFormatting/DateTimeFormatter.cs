using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.DateTimeFormatting
{
	[Activatable(typeof(IDateTimeFormatterFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDateTimeFormatterStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class DateTimeFormatter : IDateTimeFormatter
	{
		public extern string Calendar
		{
			get;
		}
		public extern string Clock
		{
			get;
		}
		public extern string GeographicRegion
		{
			get;
		}
		public extern DayFormat IncludeDay
		{
			get;
		}
		public extern DayOfWeekFormat IncludeDayOfWeek
		{
			get;
		}
		public extern HourFormat IncludeHour
		{
			get;
		}
		public extern MinuteFormat IncludeMinute
		{
			get;
		}
		public extern MonthFormat IncludeMonth
		{
			get;
		}
		public extern SecondFormat IncludeSecond
		{
			get;
		}
		public extern YearFormat IncludeYear
		{
			get;
		}
		public extern IVectorView<string> Languages
		{
			get;
		}
		public extern string NumeralSystem
		{
			get;
			set;
		}
		public extern IVectorView<string> Patterns
		{
			get;
		}
		public extern string ResolvedGeographicRegion
		{
			get;
		}
		public extern string ResolvedLanguage
		{
			get;
		}
		public extern string Template
		{
			get;
		}
		public static extern DateTimeFormatter LongDate
		{
			get;
		}
		public static extern DateTimeFormatter LongTime
		{
			get;
		}
		public static extern DateTimeFormatter ShortDate
		{
			get;
		}
		public static extern DateTimeFormatter ShortTime
		{
			get;
		}
		public extern DateTimeFormatter([In] string formatTemplate);
		public extern DateTimeFormatter([In] string formatTemplate, [In] IIterable<string> languages);
		public extern DateTimeFormatter([In] string formatTemplate, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
		public extern DateTimeFormatter([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat);
		public extern DateTimeFormatter([In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat);
		public extern DateTimeFormatter([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages);
		public extern DateTimeFormatter([In] YearFormat yearFormat, [In] MonthFormat monthFormat, [In] DayFormat dayFormat, [In] DayOfWeekFormat dayOfWeekFormat, [In] HourFormat hourFormat, [In] MinuteFormat minuteFormat, [In] SecondFormat secondFormat, [In] IIterable<string> languages, [In] string geographicRegion, [In] string calendar, [In] string clock);
		public extern string Format([In] DateTime value);
	}
}
