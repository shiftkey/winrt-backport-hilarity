using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Static(typeof(IDownloadsFolderStatics), 100794368u), Version(100794368u)]
	public static class DownloadsFolder
	{
		[Overload("CreateFileAsync")]
		public static extern IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName);
		[Overload("CreateFolderAsync")]
		public static extern IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName);
		[Overload("CreateFileWithCollisionOptionAsync")]
		public static extern IAsyncOperation<StorageFile> CreateFileAsync([In] string desiredName, [In] CreationCollisionOption option);
		[Overload("CreateFolderWithCollisionOptionAsync")]
		public static extern IAsyncOperation<StorageFolder> CreateFolderAsync([In] string desiredName, [In] CreationCollisionOption option);
	}
}
