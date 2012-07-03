using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[Version(100794368u)]
	public enum TriggeredConnectState
	{
		PeerFound,
		Listening,
		Connecting,
		Completed,
		Canceled,
		Failed
	}
}
