using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Flags, Version(100794368u)]
	public enum ThumbnailOptions : uint
	{
		None = 0u,
		ReturnOnlyIfCached = 1u,
		ResizeThumbnail = 2u,
		UseCurrentScale = 4u
	}
}
