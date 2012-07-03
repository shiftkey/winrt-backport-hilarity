using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;
namespace Windows.Storage.BulkAccess
{
	[Activatable(typeof(IFileInformationFactoryFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class FileInformationFactory : IFileInformationFactory
	{
		public extern FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode);
		public extern FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize);
		public extern FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions);
		public extern FileInformationFactory([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions, [In] bool delayLoad);
		[Overload("GetItemsAsync")]
		public extern IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetItemsAsyncDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();
		[Overload("GetFilesAsync")]
		public extern IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFilesAsyncDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();
		[Overload("GetFoldersAsync")]
		public extern IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync([In] uint startIndex, [In] uint maxItemsToRetrieve);
		[Overload("GetFoldersAsyncDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();
		public extern object GetVirtualizedItemsVector();
		public extern object GetVirtualizedFilesVector();
		public extern object GetVirtualizedFoldersVector();
	}
}
