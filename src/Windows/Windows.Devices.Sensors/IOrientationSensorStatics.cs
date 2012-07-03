using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(OrientationSensor)), Guid(284133138u, 64332, 17034, 137, 139, 39, 101, 228, 9, 230, 105), Version(100794368u)]
	internal interface IOrientationSensorStatics
	{
		OrientationSensor GetDefault();
	}
}
