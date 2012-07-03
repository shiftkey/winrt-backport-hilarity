using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(SimpleOrientationSensorOrientationChangedEventArgs)), Guid(3168126560u, 9172, 19276, 162, 46, 186, 129, 173, 224, 198, 1), Version(100794368u)]
	internal interface ISimpleOrientationSensorOrientationChangedEventArgs
	{
		SimpleOrientation Orientation
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
