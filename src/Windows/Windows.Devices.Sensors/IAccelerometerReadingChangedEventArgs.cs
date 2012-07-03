using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(AccelerometerReadingChangedEventArgs)), Guid(9815643u, 46764, 18266, 159, 68, 139, 50, 211, 90, 63, 37), Version(100794368u)]
	internal interface IAccelerometerReadingChangedEventArgs
	{
		AccelerometerReading Reading
		{
			get;
		}
	}
}
