using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class AccelerometerReading : IAccelerometerReading
	{
		public extern double AccelerationX
		{
			get;
		}
		public extern double AccelerationY
		{
			get;
		}
		public extern double AccelerationZ
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
