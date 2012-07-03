using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[Flags, Version(100794368u)]
	public enum CachedFileOptions : uint
	{
		None = 0u,
		RequireUpdateOnAccess = 1u,
		UseCachedFileWhenOffline = 2u,
		DenyAccessWhenOffline = 4u
	}
}
