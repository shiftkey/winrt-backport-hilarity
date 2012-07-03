using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Compass)), Guid(2596050911u, 22252, 19493, 181, 77, 64, 166, 139, 181, 178, 105), Version(100794368u)]
	internal interface ICompassStatics
	{
		Compass GetDefault();
	}
}
