using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(OrientationSensorReadingChangedEventArgs)), Guid(19665286u, 50106, 18108, 174, 101, 122, 152, 153, 108, 191, 184), Version(100794368u)]
	internal interface IOrientationSensorReadingChangedEventArgs
	{
		OrientationSensorReading Reading
		{
			get;
		}
	}
}
