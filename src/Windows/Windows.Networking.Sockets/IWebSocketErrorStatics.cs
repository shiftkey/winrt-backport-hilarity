using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Web;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(WebSocketError)), Guid(667808603u, 8033, 18185, 142, 2, 97, 40, 58, 218, 78, 157), Version(100794368u)]
	internal interface IWebSocketErrorStatics
	{
		WebErrorStatus GetStatus([In] int hresult);
	}
}
