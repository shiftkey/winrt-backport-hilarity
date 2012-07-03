using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(DownloadsFolder)), Guid(663105232u, 16462, 18399, 161, 226, 227, 115, 8, 190, 123, 55), Version(100794368u)]
	internal interface IDownloadsFolderStatics
	{
		[Overload("CreateFileAsync")]
		IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
		[Overload("CreateFolderAsync")]
		IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
		[Overload("CreateFileWithCollisionOptionAsync")]
		IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName, [In] CreationCollisionOption option);
		[Overload("CreateFolderWithCollisionOptionAsync")]
		IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName, [In] CreationCollisionOption option);
	}
}
