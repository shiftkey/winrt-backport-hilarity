using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Flags, Version(100794368u)]
	public enum AccessCacheOptions : uint
	{
		None = 0u,
		DisallowUserInput = 1u,
		FastLocationsOnly = 2u,
		UseReadOnlyCachedCopy = 4u,
		SuppressAccessTimeUpdate = 8u
	}
}
