using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;
using DateTime = Windows.Foundation.DateTime;
namespace Windows.Storage
{
	[Static(typeof(IStorageFolderStatics), 100794368u), Version(100794368u)]
	public sealed class StorageFolder : IStorageFolder, IStorageItem, IStorageFolderQueryOperations, IStorageItemProperties
	{
		public extern FileAttributes Attributes
		{
			get;
		}
		public extern DateTime DateCreated
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern string Path
		{
			get;
		}
		public extern string DisplayName
		{
			get;
		}
		public extern string DisplayType
		{
			get;
		}
		public extern string FolderRelativeId
		{
			get;
		}
		public extern StorageItemContentProperties Properties
		{
			get;
		}
		[Overload("CreateFileAsyncOverloadDefaultOptions")]
		public extern IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
		[Overload("CreateFileAsync")]
		public extern IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName, [In] CreationCollisionOption options);
		[Overload("CreateFolderAsyncOverloadDefaultOptions")]
		public extern IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
		[Overload("CreateFolderAsync")]
		public extern IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName, [In] CreationCollisionOption options);
		public extern IAsyncOperation<StorageFile> GetFileAsync([In] string name);
		public extern IAsyncOperation<StorageFolder> GetFolderAsync([In] string name);
		public extern IAsyncOperation<IStorageItem> GetItemAsync([In] string name);
		[Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
		public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
		[Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
		public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
		[Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
		[Overload("RenameAsyncOverloadDefaultOptions")]
		public extern IAsyncAction RenameAsync([In] string desiredName);
		[Overload("RenameAsync")]
		public extern IAsyncAction RenameAsync([In] string desiredName, [In] NameCollisionOption option);
		[Overload("DeleteAsyncOverloadDefaultOptions")]
		public extern IAsyncAction DeleteAsync();
		[Overload("DeleteAsync")]
		public extern IAsyncAction DeleteAsync([In] StorageDeleteOption option);
		public extern IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();
		public extern bool IsOfType([In] StorageItemTypes type);
		public extern IAsyncOperation<IndexedState> GetIndexedStateAsync();
		[Overload("CreateFileQueryOverloadDefault")]
		public extern StorageFileQueryResult CreateFileQuery();
		[Overload("CreateFileQuery")]
		public extern StorageFileQueryResult CreateFileQuery([In] CommonFileQuery query);
		public extern StorageFileQueryResult CreateFileQueryWithOptions([In] QueryOptions queryOptions);
		[Overload("CreateFolderQueryOverloadDefault")]
		public extern StorageFolderQueryResult CreateFolderQuery();
		[Overload("CreateFolderQuery")]
		public extern StorageFolderQueryResult CreateFolderQuery([In] CommonFolderQuery query);
		public extern StorageFolderQueryResult CreateFolderQueryWithOptions([In] QueryOptions queryOptions);
		public extern StorageItemQueryResult CreateItemQuery();
		public extern StorageItemQueryResult CreateItemQueryWithOptions([In] QueryOptions queryOptions);
		[Overload("GetFilesAsync")]
		public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] CommonFileQuery query);
		[Overload("GetFoldersAsync")]
		public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query, [In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] CommonFolderQuery query);
		[Overload("GetItemsAsync")]
		public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		public extern bool AreQueryOptionsSupported([In] QueryOptions queryOptions);
		public extern bool IsCommonFolderQuerySupported([In] CommonFolderQuery query);
		public extern bool IsCommonFileQuerySupported([In] CommonFileQuery query);
		[Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
		public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode);
		[Overload("GetThumbnailAsyncOverloadDefaultOptions")]
		public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize);
		[Overload("GetThumbnailAsync")]
		public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
		public static extern IAsyncOperation<StorageFolder> GetFolderFromPathAsync([In] string path);
	}
}
