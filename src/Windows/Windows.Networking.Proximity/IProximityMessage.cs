using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(ProximityMessage)), Guid(4020963202u, 63201, 18037, 160, 69, 216, 227, 32, 194, 72, 8), Version(100794368u)]
	internal interface IProximityMessage
	{
		IBuffer Data
		{
			get;
		}
		string DataAsString
		{
			get;
		}
		string MessageType
		{
			get;
		}
		long SubscriptionId
		{
			get;
		}
	}
}
