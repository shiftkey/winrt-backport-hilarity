using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StreamWebSocketInformation : IWebSocketInformation
	{
		public extern BandwidthStatistics BandwidthStatistics
		{
			get;
		}
		public extern HostName LocalAddress
		{
			get;
		}
		public extern string Protocol
		{
			get;
		}
	}
}
