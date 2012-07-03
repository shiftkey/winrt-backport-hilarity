using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Flags, Version(100794368u)]
	public enum InputStreamOptions : uint
	{
		None = 0u,
		Partial = 1u,
		ReadAhead = 2u
	}
}
