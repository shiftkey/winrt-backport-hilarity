using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;
namespace Windows.Storage.BulkAccess
{
	[Version(100794368u)]
	public sealed class FileInformation : IStorageItemInformation, IStorageFile, IStorageItem, IRandomAccessStreamReference, IInputStreamReference, IStorageItemProperties
	{
		public extern event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated
		{
			add;
			remove;
		}
		public extern BasicProperties BasicProperties
		{
			get;
		}
		public extern DocumentProperties DocumentProperties
		{
			get;
		}
		public extern ImageProperties ImageProperties
		{
			get;
		}
		public extern MusicProperties MusicProperties
		{
			get;
		}
		public extern StorageItemThumbnail Thumbnail
		{
			get;
		}
		public extern VideoProperties VideoProperties
		{
			get;
		}
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
	}
}
