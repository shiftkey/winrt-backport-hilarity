using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class Geocoordinate : IGeocoordinate
	{
		public extern double Accuracy
		{
			get;
		}
		public extern IReference<double> Altitude
		{
			get;
		}
		public extern IReference<double> AltitudeAccuracy
		{
			get;
		}
		public extern IReference<double> Heading
		{
			get;
		}
		public extern double Latitude
		{
			get;
		}
		public extern double Longitude
		{
			get;
		}
		public extern IReference<double> Speed
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
