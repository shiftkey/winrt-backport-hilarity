using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocketListener)), Guid(4283511863u, 57247, 19952, 191, 130, 14, 197, 215, 179, 90, 174), Version(100794368u)]
	internal interface IStreamSocketListener : IClosable
	{
		event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;
		StreamSocketListenerControl Control
		{
			get;
		}
		StreamSocketListenerInformation Information
		{
			get;
		}
		IAsyncAction BindServiceNameAsync([In] string localServiceName);
		IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
	}
}
