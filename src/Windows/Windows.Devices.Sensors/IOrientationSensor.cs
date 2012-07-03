using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(OrientationSensor)), Guid(1580549685u, 53099, 19555, 171, 216, 16, 37, 43, 11, 246, 236), Version(100794368u)]
	internal interface IOrientationSensor
	{
		event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged;
		uint MinimumReportInterval
		{
			get;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		OrientationSensorReading GetCurrentReading();
	}
}
