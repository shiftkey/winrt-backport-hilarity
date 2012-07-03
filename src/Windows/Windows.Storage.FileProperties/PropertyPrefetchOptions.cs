using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Flags, Version(100794368u)]
	public enum PropertyPrefetchOptions : uint
	{
		None = 0u,
		MusicProperties = 1u,
		VideoProperties = 2u,
		ImageProperties = 4u,
		DocumentProperties = 8u,
		BasicProperties = 16u
	}
}
