using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class WebSocketClosedEventArgs : IWebSocketClosedEventArgs
	{
		public extern ushort Code
		{
			get;
		}
		public extern string Reason
		{
			get;
		}
	}
}
