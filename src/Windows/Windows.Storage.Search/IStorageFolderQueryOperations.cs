using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Guid(3410218185u, 17515, 19023, 190, 151, 117, 119, 113, 190, 82, 3), Version(100794368u)]
	public interface IStorageFolderQueryOperations
	{
		IAsyncOperation<IndexedState> GetIndexedStateAsync();
		[Overload("CreateFileQueryOverloadDefault")]
		StorageFileQueryResult CreateFileQuery();
		[Overload("CreateFileQuery")]
		StorageFileQueryResult CreateFileQuery([In] CommonFileQuery query);
		StorageFileQueryResult CreateFileQueryWithOptions([In] QueryOptions queryOptions);
		[Overload("CreateFolderQueryOverloadDefault")]
		StorageFolderQueryResult CreateFolderQuery();
		[Overload("CreateFolderQuery")]
		StorageFolderQueryResult CreateFolderQuery([In] CommonFolderQuery query);
		StorageFolderQueryResult CreateFolderQueryWithOptions([In] QueryOptions queryOptions);
		StorageItemQueryResult CreateItemQuery();
		StorageItemQueryResult CreateItemQueryWithOptions([In] QueryOptions queryOptions);
		[Overload("GetFilesAsync")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query);
		[Overload("GetFoldersAsync")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query);
		[Overload("GetItemsAsync")]
		IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		bool AreQueryOptionsSupported([In] QueryOptions queryOptions);
		bool IsCommonFolderQuerySupported([In] CommonFolderQuery query);
		bool IsCommonFileQuerySupported([In] CommonFileQuery query);
	}
}
