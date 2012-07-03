using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(MessageWebSocket)), Guid(863141128u, 13525, 18246, 173, 123, 141, 222, 91, 194, 239, 136), Version(100794368u)]
	internal interface IMessageWebSocket : IWebSocket, IClosable
	{
		event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;
		MessageWebSocketControl Control
		{
			get;
		}
		MessageWebSocketInformation Information
		{
			get;
		}
	}
}
