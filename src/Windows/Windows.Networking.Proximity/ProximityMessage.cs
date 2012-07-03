using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Proximity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ProximityMessage : IProximityMessage
	{
		public extern IBuffer Data
		{
			get;
		}
		public extern string DataAsString
		{
			get;
		}
		public extern string MessageType
		{
			get;
		}
		public extern long SubscriptionId
		{
			get;
		}
	}
}
