using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[ExclusiveTo(typeof(StorageItemMostRecentlyUsedList)), Guid(23214549u, 20749, 16670, 140, 241, 195, 209, 239, 250, 76, 51), Version(100794368u)]
	internal interface IStorageItemMostRecentlyUsedList : IStorageItemAccessList
	{
		event TypedEventHandler<StorageItemMostRecentlyUsedList, ItemRemovedEventArgs> ItemRemoved;
	}
}
