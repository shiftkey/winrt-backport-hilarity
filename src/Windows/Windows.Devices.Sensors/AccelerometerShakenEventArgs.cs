using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class AccelerometerShakenEventArgs : IAccelerometerShakenEventArgs
	{
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
