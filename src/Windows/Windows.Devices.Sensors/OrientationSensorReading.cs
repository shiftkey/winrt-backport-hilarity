using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class OrientationSensorReading : IOrientationSensorReading
	{
		public extern SensorQuaternion Quaternion
		{
			get;
		}
		public extern SensorRotationMatrix RotationMatrix
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
