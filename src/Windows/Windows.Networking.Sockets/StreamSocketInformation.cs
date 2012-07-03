using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StreamSocketInformation : IStreamSocketInformation
	{
		public extern BandwidthStatistics BandwidthStatistics
		{
			get;
		}
		public extern HostName LocalAddress
		{
			get;
		}
		public extern string LocalPort
		{
			get;
		}
		public extern SocketProtectionLevel ProtectionLevel
		{
			get;
		}
		public extern HostName RemoteAddress
		{
			get;
		}
		public extern HostName RemoteHostName
		{
			get;
		}
		public extern string RemotePort
		{
			get;
		}
		public extern string RemoteServiceName
		{
			get;
		}
		public extern RoundTripTimeStatistics RoundTripTimeStatistics
		{
			get;
		}
		public extern IBuffer SessionKey
		{
			get;
		}
	}
}
