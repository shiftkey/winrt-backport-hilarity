using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StreamSocketListenerConnectionReceivedEventArgs : IStreamSocketListenerConnectionReceivedEventArgs
	{
		public extern StreamSocket Socket
		{
			get;
		}
	}
}
