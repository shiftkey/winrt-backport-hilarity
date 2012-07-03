using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class NetworkItem : INetworkItem
	{
		public extern Guid NetworkId
		{
			get;
		}
		public extern NetworkTypes GetNetworkTypes();
	}
}
