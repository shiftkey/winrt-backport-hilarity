using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[ExclusiveTo(typeof(Geoposition)), Guid(3247244372u, 32065, 20471, 169, 87, 157, 255, 180, 239, 127, 91), Version(100794368u)]
	internal interface IGeoposition
	{
		CivicAddress CivicAddress
		{
			get;
		}
		Geocoordinate Coordinate
		{
			get;
		}
	}
}
