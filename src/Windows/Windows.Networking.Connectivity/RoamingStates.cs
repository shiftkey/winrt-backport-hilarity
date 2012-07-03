using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[Flags, Version(100794368u)]
	public enum RoamingStates : uint
	{
		None = 0u,
		NotRoaming = 1u,
		Roaming = 2u
	}
}
