using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(StorageItemQueryResult)), Guid(3902046329u, 40280, 18360, 178, 178, 65, 176, 127, 71, 149, 249), Version(100794368u)]
	internal interface IStorageItemQueryResult : IStorageQueryResultBase
	{
		[Overload("GetItemsAsync")]
		IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetItemsAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
	}
}
