using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Flags, Version(100794368u)]
	public enum StorageItemTypes : uint
	{
		None = 0u,
		File = 1u,
		Folder = 2u
	}
}
