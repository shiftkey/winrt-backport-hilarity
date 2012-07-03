using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(MessageWebSocketMessageReceivedEventArgs)), Guid(1200366252u, 19531, 17133, 158, 215, 30, 249, 249, 79, 163, 213), Version(100794368u)]
	internal interface IMessageWebSocketMessageReceivedEventArgs
	{
		SocketMessageType MessageType
		{
			get;
		}
		DataReader GetDataReader();
		IInputStream GetDataStream();
	}
}
