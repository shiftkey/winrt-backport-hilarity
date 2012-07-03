using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(StorageFile)), Guid(1501873936u, 56050, 17352, 139, 180, 164, 211, 234, 207, 208, 63), Version(100794368u)]
	internal interface IStorageFileStatics
	{
		IAsyncOperation<StorageFile> GetFileFromPathAsync([In] string path);
		IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync([In] Uri uri);
		IAsyncOperation<StorageFile> CreateStreamedFileAsync([In] string displayNameWithExtension, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
		IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync([In] IStorageFile fileToReplace, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
		IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync([In] string displayNameWithExtension, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
		IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync([In] IStorageFile fileToReplace, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
	}
}
