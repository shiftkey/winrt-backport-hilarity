using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class StreamSocketListener : IStreamSocketListener, IClosable
	{
		public extern event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived
		{
			add;
			remove;
		}
		public extern StreamSocketListenerControl Control
		{
			get;
		}
		public extern StreamSocketListenerInformation Information
		{
			get;
		}
		public extern StreamSocketListener();
		public extern IAsyncAction BindServiceNameAsync([In] string localServiceName);
		public extern IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
		public extern void Close();
	}
}
