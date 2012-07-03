using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[ExclusiveTo(typeof(CivicAddress)), Guid(2824239642u, 25844, 19784, 188, 234, 246, 176, 8, 236, 163, 76), Version(100794368u)]
	internal interface ICivicAddress
	{
		string City
		{
			get;
		}
		string Country
		{
			get;
		}
		string PostalCode
		{
			get;
		}
		string State
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
