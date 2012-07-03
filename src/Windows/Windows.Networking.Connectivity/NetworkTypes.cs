using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[Flags, Version(100794368u)]
	public enum NetworkTypes : uint
	{
		None = 0u,
		Internet = 1u,
		PrivateNetwork = 2u
	}
}
