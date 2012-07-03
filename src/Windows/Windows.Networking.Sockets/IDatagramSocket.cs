using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(DatagramSocket)), Guid(2145541051u, 50108, 18039, 132, 70, 202, 40, 164, 101, 163, 175), Version(100794368u)]
	internal interface IDatagramSocket : IClosable
	{
		event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;
		DatagramSocketControl Control
		{
			get;
		}
		DatagramSocketInformation Information
		{
			get;
		}
		IOutputStream OutputStream
		{
			get;
		}
		[Overload("ConnectAsync")]
		IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("ConnectWithEndpointPairAsync")]
		IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
		IAsyncAction BindServiceNameAsync([In] string localServiceName);
		IAsyncAction BindEndpointAsync([In] HostName localHostName, [In] string localServiceName);
		void JoinMulticastGroup([In] HostName host);
		[Overload("GetOutputStreamAsync")]
		IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("GetOutputStreamWithEndpointPairAsync")]
		IAsyncOperation<IOutputStream> GetOutputStreamAsync([In] EndpointPair endpointPair);
	}
}
