using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class AccelerometerReadingChangedEventArgs : IAccelerometerReadingChangedEventArgs
	{
		public extern AccelerometerReading Reading
		{
			get;
		}
	}
}
