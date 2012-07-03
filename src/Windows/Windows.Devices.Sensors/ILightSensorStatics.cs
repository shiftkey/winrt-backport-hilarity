using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(LightSensor)), Guid(1172016260u, 50088, 18206, 154, 83, 100, 87, 250, 216, 124, 14), Version(100794368u)]
	internal interface ILightSensorStatics
	{
		LightSensor GetDefault();
	}
}
