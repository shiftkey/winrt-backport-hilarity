using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.DateTimeFormatting
{
	[ExclusiveTo(typeof(DateTimeFormatter)), Guid(2515454480u, 29664, 20043, 161, 131, 61, 106, 208, 186, 53, 236), Version(100794368u)]
	internal interface IDateTimeFormatter
	{
		string Calendar
		{
			get;
		}
		string Clock
		{
			get;
		}
		string GeographicRegion
		{
			get;
		}
		DayFormat IncludeDay
		{
			get;
		}
		DayOfWeekFormat IncludeDayOfWeek
		{
			get;
		}
		HourFormat IncludeHour
		{
			get;
		}
		MinuteFormat IncludeMinute
		{
			get;
		}
		MonthFormat IncludeMonth
		{
			get;
		}
		SecondFormat IncludeSecond
		{
			get;
		}
		YearFormat IncludeYear
		{
			get;
		}
		IVectorView<string> Languages
		{
			get;
		}
		string NumeralSystem
		{
			get;
			set;
		}
		IVectorView<string> Patterns
		{
			get;
		}
		string ResolvedGeographicRegion
		{
			get;
		}
		string ResolvedLanguage
		{
			get;
		}
		string Template
		{
			get;
		}
		string Format([In] DateTime value);
	}
}
