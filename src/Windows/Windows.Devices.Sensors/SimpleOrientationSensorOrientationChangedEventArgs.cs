using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SimpleOrientationSensorOrientationChangedEventArgs : ISimpleOrientationSensorOrientationChangedEventArgs
	{
		public extern SimpleOrientation Orientation
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
