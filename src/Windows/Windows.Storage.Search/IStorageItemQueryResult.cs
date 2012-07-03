using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(StorageItemQueryResult))]
	internal interface IStorageItemQueryResult : IStorageQueryResultBase
	{
		[Overload("GetItemsAsync")]
		IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetItemsAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
	}
}
