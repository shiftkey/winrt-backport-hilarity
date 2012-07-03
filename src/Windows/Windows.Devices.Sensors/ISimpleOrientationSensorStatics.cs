using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(SimpleOrientationSensor)), Guid(1928136303u, 28842, 16582, 155, 27, 52, 51, 247, 69, 155, 78), Version(100794368u)]
	internal interface ISimpleOrientationSensorStatics
	{
		SimpleOrientationSensor GetDefault();
	}
}
