using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(DatagramSocketMessageReceivedEventArgs)), Guid(2653805730u, 5906, 19684, 177, 121, 140, 101, 44, 109, 16, 126), Version(100794368u)]
	internal interface IDatagramSocketMessageReceivedEventArgs
	{
		HostName LocalAddress
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
		DataReader GetDataReader();
		IInputStream GetDataStream();
	}
}
