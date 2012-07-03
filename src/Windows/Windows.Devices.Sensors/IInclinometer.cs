using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Inclinometer)), Guid(642304623u, 8838, 16495, 145, 97, 240, 196, 189, 128, 110, 191), Version(100794368u)]
	internal interface IInclinometer
	{
		event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged;
		uint MinimumReportInterval
		{
			get;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		InclinometerReading GetCurrentReading();
	}
}
