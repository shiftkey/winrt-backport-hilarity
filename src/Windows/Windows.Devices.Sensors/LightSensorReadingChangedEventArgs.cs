using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LightSensorReadingChangedEventArgs : ILightSensorReadingChangedEventArgs
	{
		public extern LightSensorReading Reading
		{
			get;
		}
	}
}
