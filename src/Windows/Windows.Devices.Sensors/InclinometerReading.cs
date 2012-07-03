using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class InclinometerReading : IInclinometerReading
	{
		public extern float PitchDegrees
		{
			get;
		}
		public extern float RollDegrees
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
		public extern float YawDegrees
		{
			get;
		}
	}
}
