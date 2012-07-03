using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Version(100794368u)]
	public enum CollectionChange
	{
		Reset,
		ItemInserted,
		ItemRemoved,
		ItemChanged
	}
}
