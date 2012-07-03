using System;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
namespace Windows.Networking.Proximity
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class TriggeredConnectionStateChangedEventArgs : ITriggeredConnectionStateChangedEventArgs
	{
		public extern uint Id
		{
			get;
		}
		public extern StreamSocket Socket
		{
			get;
		}
		public extern TriggeredConnectState State
		{
			get;
		}
	}
}
