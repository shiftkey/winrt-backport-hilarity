using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class MessageWebSocketControl : IMessageWebSocketControl, IWebSocketControl
	{
		public extern uint MaxMessageSize
		{
			get;
			set;
		}
		public extern SocketMessageType MessageType
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
