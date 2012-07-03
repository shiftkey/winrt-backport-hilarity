using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StreamWebSocketControl : IStreamWebSocketControl, IWebSocketControl
	{
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
		public extern PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		public extern PasswordCredential ServerCredential
		{
			get;
			set;
		}
		public extern IVector<string> SupportedProtocols
		{
			get;
		}
	}
}
