using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[Flags, Version(100794368u)]
	public enum HostNameSortOptions : uint
	{
		None = 0u,
		OptimizeForLongConnections = 2u
	}
}
