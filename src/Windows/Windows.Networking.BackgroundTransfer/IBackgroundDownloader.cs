using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(BackgroundDownloader)), Guid(3251082035u, 26185, 19229, 168, 38, 164, 179, 221, 35, 77, 11), Version(100794368u)]
	internal interface IBackgroundDownloader : IBackgroundTransferBase
	{
		[Overload("CreateDownload")]
		DownloadOperation CreateDownload([In] Uri uri, [In] IStorageFile resultFile);
		[Overload("CreateDownloadFromFile")]
		DownloadOperation CreateDownload([In] Uri uri, [In] IStorageFile resultFile, [In] IStorageFile requestBodyFile);
		IAsyncOperation<DownloadOperation> CreateDownloadAsync([In] Uri uri, [In] IStorageFile resultFile, [In] IInputStream requestBodyStream);
	}
}
