using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(StorageFolderQueryResult))]
	internal interface IStorageFolderQueryResult : IStorageQueryResultBase
	{
		[Overload("GetFoldersAsync")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetFoldersAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
	}
}
