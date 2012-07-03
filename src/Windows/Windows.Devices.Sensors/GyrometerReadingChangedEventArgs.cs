using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class GyrometerReadingChangedEventArgs : IGyrometerReadingChangedEventArgs
	{
		public extern GyrometerReading Reading
		{
			get;
		}
	}
}
