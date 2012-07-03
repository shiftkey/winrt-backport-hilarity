using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class StreamSocket : IStreamSocket, IClosable
	{
		public extern StreamSocketControl Control
		{
			get;
		}
		public extern StreamSocketInformation Information
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
		public extern StreamSocket();
		[Overload("ConnectWithEndpointPairAsync")]
		public extern IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
		[DefaultOverload, Overload("ConnectAsync")]
		public extern IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
		public extern IAsyncAction ConnectAsync([In] EndpointPair endpointPair, [In] SocketProtectionLevel protectionLevel);
		[Overload("ConnectWithProtectionLevelAsync")]
		public extern IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] SocketProtectionLevel protectionLevel);
		public extern IAsyncAction UpgradeToSslAsync([In] SocketProtectionLevel protectionLevel, [In] HostName validationHostName);
		public extern void Close();
	}
}
