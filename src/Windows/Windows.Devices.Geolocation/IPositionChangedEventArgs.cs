using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[ExclusiveTo(typeof(PositionChangedEventArgs)), Guid(931503333u, 40222, 18117, 191, 59, 106, 216, 202, 193, 160, 147), Version(100794368u)]
	internal interface IPositionChangedEventArgs
	{
		Geoposition Position
		{
			get;
		}
	}
}
