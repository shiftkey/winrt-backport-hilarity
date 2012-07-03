using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(StorageFolderQueryResult)), Guid(1716832529u, 32102, 18170, 174, 207, 228, 164, 186, 169, 58, 184), Version(100794368u)]
	internal interface IStorageFolderQueryResult : IStorageQueryResultBase
	{
		[Overload("GetFoldersAsync")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetFoldersAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
	}
}
