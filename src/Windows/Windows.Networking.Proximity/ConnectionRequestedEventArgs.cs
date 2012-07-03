using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ConnectionRequestedEventArgs : IConnectionRequestedEventArgs
	{
		public extern PeerInformation PeerInformation
		{
			get;
		}
	}
}
