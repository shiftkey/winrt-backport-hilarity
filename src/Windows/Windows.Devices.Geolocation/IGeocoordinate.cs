using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[ExclusiveTo(typeof(Geocoordinate)), Guid(3995181994u, 38762, 19568, 128, 61, 8, 62, 165, 91, 203, 196), Version(100794368u)]
	internal interface IGeocoordinate
	{
		double Accuracy
		{
			get;
		}
		IReference<double> Altitude
		{
			get;
		}
		IReference<double> AltitudeAccuracy
		{
			get;
		}
		IReference<double> Heading
		{
			get;
		}
		double Latitude
		{
			get;
		}
		double Longitude
		{
			get;
		}
		IReference<double> Speed
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
