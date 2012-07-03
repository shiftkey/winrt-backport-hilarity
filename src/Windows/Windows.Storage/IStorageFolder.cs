using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Guid(1926351736u, 46063, 20341, 168, 11, 111, 217, 218, 226, 148, 75), Version(100794368u)]
	public interface IStorageFolder : IStorageItem
	{
		[Overload("CreateFileAsyncOverloadDefaultOptions")]
		IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
		[Overload("CreateFileAsync")]
		IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName, [In] CreationCollisionOption options);
		[Overload("CreateFolderAsyncOverloadDefaultOptions")]
		IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
		[Overload("CreateFolderAsync")]
		IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName, [In] CreationCollisionOption options);
		IAsyncOperation<StorageFile> GetFileAsync([In] string name);
		IAsyncOperation<StorageFolder> GetFolderAsync([In] string name);
		IAsyncOperation<IStorageItem> GetItemAsync([In] string name);
		[Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
		[Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
		IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
		[Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
		IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
	}
}
