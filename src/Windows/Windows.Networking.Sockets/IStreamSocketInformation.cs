using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocketInformation)), Guid(998288944u, 24168, 16901, 136, 240, 220, 133, 210, 226, 93, 237), Version(100794368u)]
	internal interface IStreamSocketInformation
	{
		BandwidthStatistics BandwidthStatistics
		{
			get;
		}
		HostName LocalAddress
		{
			get;
		}
		string LocalPort
		{
			get;
		}
		SocketProtectionLevel ProtectionLevel
		{
			get;
		}
		HostName RemoteAddress
		{
			get;
		}
		HostName RemoteHostName
		{
			get;
		}
		string RemotePort
		{
			get;
		}
		string RemoteServiceName
		{
			get;
		}
		RoundTripTimeStatistics RoundTripTimeStatistics
		{
			get;
		}
		IBuffer SessionKey
		{
			get;
		}
	}
}
