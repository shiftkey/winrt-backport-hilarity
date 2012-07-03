using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[Activatable(typeof(ICalendarFactory), 100794368u), Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Calendar : ICalendar
	{
		public extern int Day
		{
			get;
			set;
		}
		public extern DayOfWeek DayOfWeek
		{
			get;
		}
		public extern int Era
		{
			get;
			set;
		}
		public extern int FirstDayInThisMonth
		{
			get;
		}
		public extern int FirstEra
		{
			get;
		}
		public extern int FirstHourInThisPeriod
		{
			get;
		}
		public extern int FirstMinuteInThisHour
		{
			get;
		}
		public extern int FirstMonthInThisYear
		{
			get;
		}
		public extern int FirstPeriodInThisDay
		{
			get;
		}
		public extern int FirstSecondInThisMinute
		{
			get;
		}
		public extern int FirstYearInThisEra
		{
			get;
		}
		public extern int Hour
		{
			get;
			set;
		}
		public extern bool IsDaylightSavingTime
		{
			get;
		}
		public extern IVectorView<string> Languages
		{
			get;
		}
		public extern int LastDayInThisMonth
		{
			get;
		}
		public extern int LastEra
		{
			get;
		}
		public extern int LastHourInThisPeriod
		{
			get;
		}
		public extern int LastMinuteInThisHour
		{
			get;
		}
		public extern int LastMonthInThisYear
		{
			get;
		}
		public extern int LastPeriodInThisDay
		{
			get;
		}
		public extern int LastSecondInThisMinute
		{
			get;
		}
		public extern int LastYearInThisEra
		{
			get;
		}
		public extern int Minute
		{
			get;
			set;
		}
		public extern int Month
		{
			get;
			set;
		}
		public extern int Nanosecond
		{
			get;
			set;
		}
		public extern int NumberOfDaysInThisMonth
		{
			get;
		}
		public extern int NumberOfEras
		{
			get;
		}
		public extern int NumberOfHoursInThisPeriod
		{
			get;
		}
		public extern int NumberOfMinutesInThisHour
		{
			get;
		}
		public extern int NumberOfMonthsInThisYear
		{
			get;
		}
		public extern int NumberOfPeriodsInThisDay
		{
			get;
		}
		public extern int NumberOfSecondsInThisMinute
		{
			get;
		}
		public extern int NumberOfYearsInThisEra
		{
			get;
		}
		public extern string NumeralSystem
		{
			get;
			set;
		}
		public extern int Period
		{
			get;
			set;
		}
		public extern string ResolvedLanguage
		{
			get;
		}
		public extern int Second
		{
			get;
			set;
		}
		public extern int Year
		{
			get;
			set;
		}
		public extern Calendar([In] IIterable<string> languages);
		public extern Calendar([In] IIterable<string> languages, [In] string calendar, [In] string clock);
		public extern Calendar();
		public extern Calendar Clone();
		public extern void SetToMin();
		public extern void SetToMax();
		public extern string GetCalendarSystem();
		public extern void ChangeCalendarSystem([In] string value);
		public extern string GetClock();
		public extern void ChangeClock([In] string value);
		public extern DateTime GetDateTime();
		public extern void SetDateTime([In] DateTime value);
		public extern void SetToNow();
		public extern void AddEras([In] int eras);
		[DefaultOverload, Overload("EraAsFullString")]
		public extern string EraAsString();
		[Overload("EraAsString")]
		public extern string EraAsString([In] int idealLength);
		public extern void AddYears([In] int years);
		public extern string YearAsString();
		public extern string YearAsTruncatedString([In] int remainingDigits);
		public extern string YearAsPaddedString([In] int minDigits);
		public extern void AddMonths([In] int months);
		[DefaultOverload, Overload("MonthAsFullString")]
		public extern string MonthAsString();
		[Overload("MonthAsString")]
		public extern string MonthAsString([In] int idealLength);
		[DefaultOverload, Overload("MonthAsFullSoloString")]
		public extern string MonthAsSoloString();
		[Overload("MonthAsSoloString")]
		public extern string MonthAsSoloString([In] int idealLength);
		public extern string MonthAsNumericString();
		public extern string MonthAsPaddedNumericString([In] int minDigits);
		public extern void AddWeeks([In] int weeks);
		public extern void AddDays([In] int days);
		public extern string DayAsString();
		public extern string DayAsPaddedString([In] int minDigits);
		[DefaultOverload, Overload("DayOfWeekAsFullString")]
		public extern string DayOfWeekAsString();
		[Overload("DayOfWeekAsString")]
		public extern string DayOfWeekAsString([In] int idealLength);
		[DefaultOverload, Overload("DayOfWeekAsFullSoloString")]
		public extern string DayOfWeekAsSoloString();
		[Overload("DayOfWeekAsSoloString")]
		public extern string DayOfWeekAsSoloString([In] int idealLength);
		public extern void AddPeriods([In] int periods);
		[DefaultOverload, Overload("PeriodAsFullString")]
		public extern string PeriodAsString();
		[Overload("PeriodAsString")]
		public extern string PeriodAsString([In] int idealLength);
		public extern void AddHours([In] int hours);
		public extern string HourAsString();
		public extern string HourAsPaddedString([In] int minDigits);
		public extern void AddMinutes([In] int minutes);
		public extern string MinuteAsString();
		public extern string MinuteAsPaddedString([In] int minDigits);
		public extern void AddSeconds([In] int seconds);
		public extern string SecondAsString();
		public extern string SecondAsPaddedString([In] int minDigits);
		public extern void AddNanoseconds([In] int nanoseconds);
		public extern string NanosecondAsString();
		public extern string NanosecondAsPaddedString([In] int minDigits);
		public extern int Compare([In] Calendar other);
		public extern int CompareDateTime([In] DateTime other);
		public extern void CopyTo([In] Calendar other);
	}
}
