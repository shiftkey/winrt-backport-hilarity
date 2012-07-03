using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(MessageWebSocketControl)), Guid(2165848202u, 50729, 20234, 128, 251, 129, 252, 5, 83, 136, 98), Version(100794368u)]
	internal interface IMessageWebSocketControl : IWebSocketControl
	{
		uint MaxMessageSize
		{
			get;
			set;
		}
		SocketMessageType MessageType
		{
			get;
			set;
		}
	}
}
