using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CivicAddress : ICivicAddress
	{
		public extern string City
		{
			get;
		}
		public extern string Country
		{
			get;
		}
		public extern string PostalCode
		{
			get;
		}
		public extern string State
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
	}
}
