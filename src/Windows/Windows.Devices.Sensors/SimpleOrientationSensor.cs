using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISimpleOrientationSensorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SimpleOrientationSensor : ISimpleOrientationSensor
	{
		public extern event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged
		{
			add;
			remove;
		}
		public extern SimpleOrientation GetCurrentOrientation();
		public static extern SimpleOrientationSensor GetDefault();
	}
}
