using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(DownloadsFolder))]
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
