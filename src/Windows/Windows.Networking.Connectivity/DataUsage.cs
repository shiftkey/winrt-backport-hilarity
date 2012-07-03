using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataUsage : IDataUsage
	{
		public extern ulong BytesReceived
		{
			get;
		}
		public extern ulong BytesSent
		{
			get;
		}
	}
}
