using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public enum IndexedState
	{
		Unknown,
		NotIndexed,
		PartiallyIndexed,
		FullyIndexed
	}
}
