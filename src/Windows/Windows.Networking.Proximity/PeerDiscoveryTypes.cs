using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[Flags, Version(100794368u)]
	public enum PeerDiscoveryTypes : uint
	{
		None = 0u,
		Browse = 1u,
		Triggered = 2u
	}
}
