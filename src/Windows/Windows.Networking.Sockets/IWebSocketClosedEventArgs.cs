using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(WebSocketClosedEventArgs)), Guid(3468135687u, 53416, 18179, 160, 145, 200, 194, 192, 145, 91, 195), Version(100794368u)]
	internal interface IWebSocketClosedEventArgs
	{
		ushort Code
		{
			get;
		}
		string Reason
		{
			get;
		}
	}
}
