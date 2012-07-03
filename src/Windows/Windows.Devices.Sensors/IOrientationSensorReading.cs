using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(OrientationSensorReading)), Guid(1196870035u, 26005, 18583, 188, 198, 213, 55, 238, 117, 117, 100), Version(100794368u)]
	internal interface IOrientationSensorReading
	{
		SensorQuaternion Quaternion
		{
			get;
		}
		SensorRotationMatrix RotationMatrix
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
