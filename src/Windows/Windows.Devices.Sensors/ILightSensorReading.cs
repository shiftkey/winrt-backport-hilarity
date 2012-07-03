using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(LightSensorReading)), Guid(4292829952u, 8828, 19755, 179, 2, 252, 1, 66, 72, 92, 104), Version(100794368u)]
	internal interface ILightSensorReading
	{
		float IlluminanceInLux
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
