using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[Guid(4168563055u, 39345, 19992, 188, 8, 133, 12, 154, 223, 21, 110), Version(100794368u)]
	public interface IWebSocket : IClosable
	{
		event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;
		IOutputStream OutputStream
		{
			get;
		}
		IAsyncAction ConnectAsync([In] Uri uri);
		void SetRequestHeader([In] string headerName, [In] string headerValue);
		[Overload("CloseWithStatus")]
		void Close([In] ushort code, [In] string reason);
	}
}
