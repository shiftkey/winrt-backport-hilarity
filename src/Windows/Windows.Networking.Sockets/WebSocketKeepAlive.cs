using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WebSocketKeepAlive : IBackgroundTask
	{
		public extern WebSocketKeepAlive();
		public extern void Run([In] IBackgroundTaskInstance taskInstance);
	}
}
