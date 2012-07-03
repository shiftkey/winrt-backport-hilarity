using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDatagramSocketStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class DatagramSocket : IDatagramSocket, IClosable
	{
		public extern event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived
		{
			add;
			remove;
		}
		public extern DatagramSocketControl Control
		{
			get;
		}
		public extern DatagramSocketInformation Information
		{
			get;
		}
		public extern IOutputStream OutputStream
		{
			get;
		}
		public extern DatagramSocket();
		[Overload("ConnectAsync")]
		public extern IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("ConnectWithEndpointPairAsync")]
		public extern IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
		public extern IAsyncAction BindServiceNameAsync([In] string localServiceName);
		public extern IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
		public extern void JoinMulticastGroup([In] HostName host);
		[Overload("GetOutputStreamAsync")]
		public extern IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("GetOutputStreamWithEndpointPairAsync")]
		public extern IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] EndpointPair endpointPair);
		public extern void Close();
		[Overload("GetEndpointPairsAsync")]
		public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("GetEndpointPairsWithSortOptionsAsync")]
		public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] HostNameSortOptions sortOptions);
	}
}
