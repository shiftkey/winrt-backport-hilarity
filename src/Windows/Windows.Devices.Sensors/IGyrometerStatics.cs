using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Gyrometer)), Guid(2209802185u, 58525, 19257, 134, 230, 205, 85, 75, 228, 197, 193), Version(100794368u)]
	internal interface IGyrometerStatics
	{
		Gyrometer GetDefault();
	}
}
