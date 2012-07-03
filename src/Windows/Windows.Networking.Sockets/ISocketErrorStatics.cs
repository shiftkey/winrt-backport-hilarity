using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(SocketError)), Guid(2189637620u, 32086, 19854, 183, 180, 160, 125, 215, 193, 188, 169), Version(100794368u)]
	internal interface ISocketErrorStatics
	{
		SocketErrorStatus GetStatus([In] int hresult);
	}
}
