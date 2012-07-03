using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;
namespace Windows.Storage.BulkAccess
{
	[ExclusiveTo(typeof(FileInformationFactory)), Guid(2229931645u, 58530, 20224, 138, 250, 175, 94, 15, 130, 107, 213), Version(100794368u)]
	internal interface IFileInformationFactoryFactory
	{
		FileInformationFactory CreateWithMode([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode);
		FileInformationFactory CreateWithModeAndSize([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize);
		FileInformationFactory CreateWithModeAndSizeAndOptions([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions);
		FileInformationFactory CreateWithModeAndSizeAndOptionsAndFlags([In] IStorageQueryResultBase queryResult, [In] ThumbnailMode mode, [In] uint requestedThumbnailSize, [In] ThumbnailOptions thumbnailOptions, [In] bool delayLoad);
	}
}
