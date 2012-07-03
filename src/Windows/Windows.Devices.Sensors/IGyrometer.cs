using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Gyrometer)), Guid(4256803268u, 33969, 19618, 151, 99, 155, 88, 149, 6, 199, 12), Version(100794368u)]
	internal interface IGyrometer
	{
		event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged;
		uint MinimumReportInterval
		{
			get;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		GyrometerReading GetCurrentReading();
	}
}
