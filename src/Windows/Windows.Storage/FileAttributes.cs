using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Flags, Version(100794368u)]
	public enum FileAttributes : uint
	{
		Normal = 0u,
		ReadOnly = 1u,
		Directory = 16u,
		Archive = 32u,
		Temporary = 256u
	}
}
