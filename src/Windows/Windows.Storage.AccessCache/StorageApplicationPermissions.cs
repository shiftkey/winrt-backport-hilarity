using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Static(typeof(IStorageApplicationPermissionsStatics), 100794368u), Version(100794368u)]
	public static class StorageApplicationPermissions
	{
		public static extern StorageItemAccessList FutureAccessList
		{
			get;
		}
		public static extern StorageItemMostRecentlyUsedList MostRecentlyUsedList
		{
			get;
		}
	}
}
