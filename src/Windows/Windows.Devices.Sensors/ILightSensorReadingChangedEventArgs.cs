using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(LightSensorReadingChangedEventArgs)), Guid(2745365711u, 9611, 16908, 184, 171, 142, 221, 96, 30, 207, 80), Version(100794368u)]
	internal interface ILightSensorReadingChangedEventArgs
	{
		LightSensorReading Reading
		{
			get;
		}
	}
}
