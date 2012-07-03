using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;
using DateTime = Windows.Foundation.DateTime;

namespace Windows.Storage
{
	[Static(typeof(IStorageFileStatics), 100794368u), Version(100794368u)]
	public sealed class StorageFile : IStorageFile, IStorageItem, IRandomAccessStreamReference, IInputStreamReference, IStorageItemProperties
	{
		public extern string ContentType
		{
			get;
		}
		public extern string FileType
		{
			get;
		}
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
		public extern IAsyncOperation<IRandomAccessStream> OpenAsync([In] FileAccessMode accessMode);
		public extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();
		[Overload("CopyOverloadDefaultNameAndOptions")]
		public extern IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder);
		[Overload("CopyOverloadDefaultOptions")]
		public extern IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
		[Overload("CopyOverload")]
		public extern IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
		public extern IAsyncAction CopyAndReplaceAsync([In] IStorageFile fileToReplace);
		[Overload("MoveOverloadDefaultNameAndOptions")]
		public extern IAsyncAction MoveAsync([In] IStorageFolder destinationFolder);
		[Overload("MoveOverloadDefaultOptions")]
		public extern IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
		[Overload("MoveOverload")]
		public extern IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
		public extern IAsyncAction MoveAndReplaceAsync([In] IStorageFile fileToReplace);
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
		public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
		public extern IAsyncOperation<IInputStream> OpenSequentialReadAsync();
		[Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
		public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode);
		[Overload("GetThumbnailAsyncOverloadDefaultOptions")]
		public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize);
		[Overload("GetThumbnailAsync")]
		public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
		public static extern IAsyncOperation<StorageFile> GetFileFromPathAsync([In] string path);
		public static extern IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync([In] Uri uri);
		public static extern IAsyncOperation<StorageFile> CreateStreamedFileAsync([In] string displayNameWithExtension, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
		public static extern IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync([In] IStorageFile fileToReplace, [In] StreamedFileDataRequestedHandler dataRequested, [In] IRandomAccessStreamReference thumbnail);
		public static extern IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync([In] string displayNameWithExtension, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
		public static extern IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync([In] IStorageFile fileToReplace, [In] Uri uri, [In] IRandomAccessStreamReference thumbnail);
	}
}
