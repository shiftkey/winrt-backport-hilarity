using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CompassReading : ICompassReading
	{
		public extern double HeadingMagneticNorth
		{
			get;
		}
		public extern IReference<double> HeadingTrueNorth
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
