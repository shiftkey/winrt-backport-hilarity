using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Guid(1577181974u, 51498, 18341, 178, 95, 7, 132, 118, 57, 209, 129), Version(100794368u)]
	public interface IWebSocketInformation
	{
		BandwidthStatistics BandwidthStatistics
		{
			get;
		}
		HostName LocalAddress
		{
			get;
		}
		string Protocol
		{
			get;
		}
	}
}
