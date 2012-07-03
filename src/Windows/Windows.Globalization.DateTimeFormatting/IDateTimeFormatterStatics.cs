using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.DateTimeFormatting
{
	[ExclusiveTo(typeof(DateTimeFormatter)), Guid(3217942464u, 57164, 18990, 144, 18, 244, 125, 175, 63, 18, 18), Version(100794368u)]
	internal interface IDateTimeFormatterStatics
	{
		DateTimeFormatter LongDate
		{
			get;
		}
		DateTimeFormatter LongTime
		{
			get;
		}
		DateTimeFormatter ShortDate
		{
			get;
		}
		DateTimeFormatter ShortTime
		{
			get;
		}
	}
}
