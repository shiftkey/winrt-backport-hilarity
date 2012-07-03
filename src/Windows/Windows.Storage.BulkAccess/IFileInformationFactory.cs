using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.BulkAccess
{
	[ExclusiveTo(typeof(FileInformationFactory)), Guid(1075677374u, 38415, 19821, 167, 208, 26, 56, 97, 231, 108, 131), Version(100794368u)]
	internal interface IFileInformationFactory
	{
		[Overload("GetItemsAsync")]
		IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetItemsAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();
		[Overload("GetFilesAsync")]
		IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFilesAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();
		[Overload("GetFoldersAsync")]
		IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFoldersAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();
		object GetVirtualizedItemsVector();
		object GetVirtualizedFilesVector();
		object GetVirtualizedFoldersVector();
	}
}
