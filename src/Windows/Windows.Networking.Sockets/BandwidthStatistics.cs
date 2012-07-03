using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Version(100794368u)]
	public struct BandwidthStatistics
	{
		public ulong OutboundBitsPerSecond;
		public ulong InboundBitsPerSecond;
		public ulong OutboundBitsPerSecondInstability;
		public ulong InboundBitsPerSecondInstability;
		public bool OutboundBandwidthPeaked;
		public bool InboundBandwidthPeaked;
	}
}
