using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(LightSensor)), Guid(4165732120u, 3156, 18350, 146, 46, 120, 159, 87, 251, 3, 160), Version(100794368u)]
	internal interface ILightSensor
	{
		event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;
		uint MinimumReportInterval
		{
			get;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		LightSensorReading GetCurrentReading();
	}
}
