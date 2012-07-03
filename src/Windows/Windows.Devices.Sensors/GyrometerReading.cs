using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class GyrometerReading : IGyrometerReading
	{
		public extern double AngularVelocityX
		{
			get;
		}
		public extern double AngularVelocityY
		{
			get;
		}
		public extern double AngularVelocityZ
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
