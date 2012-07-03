using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Accelerometer)), Guid(2783087476u, 23175, 18989, 190, 204, 15, 144, 110, 160, 97, 221), Version(100794368u)]
	internal interface IAccelerometerStatics
	{
		Accelerometer GetDefault();
	}
}
