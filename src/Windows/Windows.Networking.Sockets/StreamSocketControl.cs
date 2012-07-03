using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StreamSocketControl : IStreamSocketControl
	{
		public extern bool KeepAlive
		{
			get;
			set;
		}
		public extern bool NoDelay
		{
			get;
			set;
		}
		public extern uint OutboundBufferSizeInBytes
		{
			get;
			set;
		}
		public extern byte OutboundUnicastHopLimit
		{
			get;
			set;
		}
		public extern SocketQualityOfService QualityOfService
		{
			get;
			set;
		}
	}
}
