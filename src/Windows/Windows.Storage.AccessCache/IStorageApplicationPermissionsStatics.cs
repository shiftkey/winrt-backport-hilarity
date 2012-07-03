using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[ExclusiveTo(typeof(StorageApplicationPermissions)), Guid(1133633450u, 53299, 18681, 128, 96, 62, 200, 71, 210, 227, 241), Version(100794368u)]
	internal interface IStorageApplicationPermissionsStatics
	{
		StorageItemAccessList FutureAccessList
		{
			get;
		}
		StorageItemMostRecentlyUsedList MostRecentlyUsedList
		{
			get;
		}
	}
}
