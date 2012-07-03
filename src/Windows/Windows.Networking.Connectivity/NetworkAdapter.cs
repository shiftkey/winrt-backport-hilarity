using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class NetworkAdapter : INetworkAdapter
	{
		public extern uint IanaInterfaceType
		{
			get;
		}
		public extern ulong InboundMaxBitsPerSecond
		{
			get;
		}
		public extern Guid NetworkAdapterId
		{
			get;
		}
		public extern NetworkItem NetworkItem
		{
			get;
		}
		public extern ulong OutboundMaxBitsPerSecond
		{
			get;
		}
		public extern IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();
	}
}
