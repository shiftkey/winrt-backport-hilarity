using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class MessageWebSocket : IMessageWebSocket, IWebSocket, IClosable
	{
		public extern event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed
		{
			add;
			remove;
		}
		public extern MessageWebSocketControl Control
		{
			get;
		}
		public extern MessageWebSocketInformation Information
		{
			get;
		}
		public extern IOutputStream OutputStream
		{
			get;
		}
		public extern MessageWebSocket();
		public extern IAsyncAction ConnectAsync([In] Uri uri);
		public extern void SetRequestHeader([In] string headerName, [In] string headerValue);
		[Overload("CloseWithStatus")]
		public extern void Close([In] ushort code, [In] string reason);
		public extern void Close();
	}
}
