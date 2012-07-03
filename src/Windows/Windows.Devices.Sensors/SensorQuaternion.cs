using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SensorQuaternion : ISensorQuaternion
	{
		public extern float W
		{
			get;
		}
		public extern float X
		{
			get;
		}
		public extern float Y
		{
			get;
		}
		public extern float Z
		{
			get;
		}
	}
}
