using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(ClockIdentifiers)), Guid(1379403195u, 4844, 20355, 188, 49, 177, 180, 55, 107, 8, 8), Version(100794368u)]
	internal interface IClockIdentifiersStatics
	{
		string TwelveHour
		{
			get;
		}
		string TwentyFourHour
		{
			get;
		}
	}
}
