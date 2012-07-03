using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISocketErrorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class SocketError
	{
		public static extern SocketErrorStatus GetStatus([In] int hresult);
	}
}
