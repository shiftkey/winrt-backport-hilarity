using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocket)), Guid(1772236019u, 64635, 18519, 175, 56, 246, 231, 222, 106, 91, 73), Version(100794368u)]
	internal interface IStreamSocket : IClosable
	{
		StreamSocketControl Control
		{
			get;
		}
		StreamSocketInformation Information
		{
			get;
		}
		IInputStream InputStream
		{
			get;
		}
		IOutputStream OutputStream
		{
			get;
		}
		[Overload("ConnectWithEndpointPairAsync")]
		IAsyncAction ConnectAsync([In] EndpointPair endpointPair);
		[DefaultOverload, Overload("ConnectAsync")]
		IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
		IAsyncAction ConnectAsync([In] EndpointPair endpointPair, [In] SocketProtectionLevel protectionLevel);
		[Overload("ConnectWithProtectionLevelAsync")]
		IAsyncAction ConnectAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] SocketProtectionLevel protectionLevel);
		IAsyncAction UpgradeToSslAsync([In] SocketProtectionLevel protectionLevel, [In] HostName validationHostName);
	}
}
