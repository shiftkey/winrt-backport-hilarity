using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Compass)), Guid(691010196u, 6981, 16444, 186, 6, 177, 6, 219, 166, 154, 100), Version(100794368u)]
	internal interface ICompass
	{
		event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged;
		uint MinimumReportInterval
		{
			get;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		CompassReading GetCurrentReading();
	}
}
