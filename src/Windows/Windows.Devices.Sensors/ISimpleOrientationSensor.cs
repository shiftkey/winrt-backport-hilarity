using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(SimpleOrientationSensor)), Guid(1609906262u, 8522, 19950, 163, 249, 97, 111, 26, 176, 111, 253), Version(100794368u)]
	internal interface ISimpleOrientationSensor
	{
		event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged;
		SimpleOrientation GetCurrentOrientation();
	}
}
