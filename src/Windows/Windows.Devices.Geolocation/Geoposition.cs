using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class Geoposition : IGeoposition
	{
		public extern CivicAddress CivicAddress
		{
			get;
		}
		public extern Geocoordinate Coordinate
		{
			get;
		}
	}
}
