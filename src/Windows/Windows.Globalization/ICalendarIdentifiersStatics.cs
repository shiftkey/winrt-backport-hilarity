using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(CalendarIdentifiers)), Guid(2154119016u, 11442, 19487, 181, 144, 240, 245, 43, 244, 253, 26), Version(100794368u)]
	internal interface ICalendarIdentifiersStatics
	{
		string Gregorian
		{
			get;
		}
		string Hebrew
		{
			get;
		}
		string Hijri
		{
			get;
		}
		string Japanese
		{
			get;
		}
		string Julian
		{
			get;
		}
		string Korean
		{
			get;
		}
		string Taiwan
		{
			get;
		}
		string Thai
		{
			get;
		}
		string UmAlQura
		{
			get;
		}
	}
}
