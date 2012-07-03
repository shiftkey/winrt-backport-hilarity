using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocketListenerConnectionReceivedEventArgs)), Guid(205991593u, 14143, 17531, 133, 177, 221, 212, 84, 136, 3, 186), Version(100794368u)]
	internal interface IStreamSocketListenerConnectionReceivedEventArgs
	{
		StreamSocket Socket
		{
			get;
		}
	}
}
