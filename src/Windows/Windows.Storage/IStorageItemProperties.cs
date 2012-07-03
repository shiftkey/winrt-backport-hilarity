using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
namespace Windows.Storage
{
	public interface IStorageItemProperties
	{
		string DisplayName
		{
			get;
		}
		string DisplayType
		{
			get;
		}
		string FolderRelativeId
		{
			get;
		}
		StorageItemContentProperties Properties
		{
			get;
		}
		[Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
		IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode);
		[Overload("GetThumbnailAsyncOverloadDefaultOptions")]
		IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize);
		[Overload("GetThumbnailAsync")]
		IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
	}
}
