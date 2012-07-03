using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public struct SortEntry
	{
		public string PropertyName;
		public bool AscendingOrder;
	}
}
