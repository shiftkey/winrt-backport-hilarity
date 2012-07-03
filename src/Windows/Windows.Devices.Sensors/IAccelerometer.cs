using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Accelerometer)), Guid(3742909768u, 10001, 19879, 128, 152, 75, 130, 32, 93, 60, 125), Version(100794368u)]
	internal interface IAccelerometer
	{
		event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;
		event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;
		uint MinimumReportInterval
		{
			get;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		AccelerometerReading GetCurrentReading();
	}
}
