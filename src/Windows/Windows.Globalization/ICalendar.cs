using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(Calendar)), Guid(3392152093u, 34521, 16635, 162, 107, 212, 78, 183, 207, 8, 234), Version(100794368u)]
	internal interface ICalendar
	{
		int Day
		{
			get;
			set;
		}
		DayOfWeek DayOfWeek
		{
			get;
		}
		int Era
		{
			get;
			set;
		}
		int FirstDayInThisMonth
		{
			get;
		}
		int FirstEra
		{
			get;
		}
		int FirstHourInThisPeriod
		{
			get;
		}
		int FirstMinuteInThisHour
		{
			get;
		}
		int FirstMonthInThisYear
		{
			get;
		}
		int FirstPeriodInThisDay
		{
			get;
		}
		int FirstSecondInThisMinute
		{
			get;
		}
		int FirstYearInThisEra
		{
			get;
		}
		int Hour
		{
			get;
			set;
		}
		bool IsDaylightSavingTime
		{
			get;
		}
		IVectorView<string> Languages
		{
			get;
		}
		int LastDayInThisMonth
		{
			get;
		}
		int LastEra
		{
			get;
		}
		int LastHourInThisPeriod
		{
			get;
		}
		int LastMinuteInThisHour
		{
			get;
		}
		int LastMonthInThisYear
		{
			get;
		}
		int LastPeriodInThisDay
		{
			get;
		}
		int LastSecondInThisMinute
		{
			get;
		}
		int LastYearInThisEra
		{
			get;
		}
		int Minute
		{
			get;
			set;
		}
		int Month
		{
			get;
			set;
		}
		int Nanosecond
		{
			get;
			set;
		}
		int NumberOfDaysInThisMonth
		{
			get;
		}
		int NumberOfEras
		{
			get;
		}
		int NumberOfHoursInThisPeriod
		{
			get;
		}
		int NumberOfMinutesInThisHour
		{
			get;
		}
		int NumberOfMonthsInThisYear
		{
			get;
		}
		int NumberOfPeriodsInThisDay
		{
			get;
		}
		int NumberOfSecondsInThisMinute
		{
			get;
		}
		int NumberOfYearsInThisEra
		{
			get;
		}
		string NumeralSystem
		{
			get;
			set;
		}
		int Period
		{
			get;
			set;
		}
		string ResolvedLanguage
		{
			get;
		}
		int Second
		{
			get;
			set;
		}
		int Year
		{
			get;
			set;
		}
		Calendar Clone();
		void SetToMin();
		void SetToMax();
		string GetCalendarSystem();
		void ChangeCalendarSystem([In] string value);
		string GetClock();
		void ChangeClock([In] string value);
		DateTime GetDateTime();
		void SetDateTime([In] DateTime value);
		void SetToNow();
		void AddEras([In] int eras);
		[DefaultOverload, Overload("EraAsFullString")]
		string EraAsString();
		[Overload("EraAsString")]
		string EraAsString([In] int idealLength);
		void AddYears([In] int years);
		string YearAsString();
		string YearAsTruncatedString([In] int remainingDigits);
		string YearAsPaddedString([In] int minDigits);
		void AddMonths([In] int months);
		[DefaultOverload, Overload("MonthAsFullString")]
		string MonthAsString();
		[Overload("MonthAsString")]
		string MonthAsString([In] int idealLength);
		[DefaultOverload, Overload("MonthAsFullSoloString")]
		string MonthAsSoloString();
		[Overload("MonthAsSoloString")]
		string MonthAsSoloString([In] int idealLength);
		string MonthAsNumericString();
		string MonthAsPaddedNumericString([In] int minDigits);
		void AddWeeks([In] int weeks);
		void AddDays([In] int days);
		string DayAsString();
		string DayAsPaddedString([In] int minDigits);
		[DefaultOverload, Overload("DayOfWeekAsFullString")]
		string DayOfWeekAsString();
		[Overload("DayOfWeekAsString")]
		string DayOfWeekAsString([In] int idealLength);
		[DefaultOverload, Overload("DayOfWeekAsFullSoloString")]
		string DayOfWeekAsSoloString();
		[Overload("DayOfWeekAsSoloString")]
		string DayOfWeekAsSoloString([In] int idealLength);
		void AddPeriods([In] int periods);
		[DefaultOverload, Overload("PeriodAsFullString")]
		string PeriodAsString();
		[Overload("PeriodAsString")]
		string PeriodAsString([In] int idealLength);
		void AddHours([In] int hours);
		string HourAsString();
		string HourAsPaddedString([In] int minDigits);
		void AddMinutes([In] int minutes);
		string MinuteAsString();
		string MinuteAsPaddedString([In] int minDigits);
		void AddSeconds([In] int seconds);
		string SecondAsString();
		string SecondAsPaddedString([In] int minDigits);
		void AddNanoseconds([In] int nanoseconds);
		string NanosecondAsString();
		string NanosecondAsPaddedString([In] int minDigits);
		int Compare([In] Calendar other);
		int CompareDateTime([In] DateTime other);
		void CopyTo([In] Calendar other);
	}
}
