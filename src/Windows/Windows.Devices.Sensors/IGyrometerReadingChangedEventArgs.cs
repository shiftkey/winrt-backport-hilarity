using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(GyrometerReadingChangedEventArgs)), Guid(266279061u, 28574, 17102, 141, 88, 56, 140, 10, 184, 53, 109), Version(100794368u)]
	internal interface IGyrometerReadingChangedEventArgs
	{
		GyrometerReading Reading
		{
			get;
		}
	}
}
