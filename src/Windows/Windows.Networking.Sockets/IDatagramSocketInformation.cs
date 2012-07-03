using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(DatagramSocketInformation)), Guid(1595561626u, 22011, 18637, 151, 6, 122, 151, 79, 123, 21, 133), Version(100794368u)]
	internal interface IDatagramSocketInformation
	{
		HostName LocalAddress
		{
			get;
		}
		string LocalPort
		{
			get;
		}
		HostName RemoteAddress
		{
			get;
		}
		string RemotePort
		{
			get;
		}
	}
}
