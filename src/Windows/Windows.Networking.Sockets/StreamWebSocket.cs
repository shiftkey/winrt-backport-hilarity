using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class StreamWebSocket : IStreamWebSocket, IWebSocket, IClosable
	{
		public extern event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed
		{
			add;
			remove;
		}
		public extern StreamWebSocketControl Control
		{
			get;
		}
		public extern StreamWebSocketInformation Information
		{
			get;
		}
		public extern IInputStream InputStream
		{
			get;
		}
		public extern IOutputStream OutputStream
		{
			get;
		}
		public extern StreamWebSocket();
		public extern IAsyncAction ConnectAsync([In] Uri uri);
		public extern void SetRequestHeader([In] string headerName, [In] string headerValue);
		[Overload("CloseWithStatus")]
		public extern void Close([In] ushort code, [In] string reason);
		public extern void Close();
	}
}
