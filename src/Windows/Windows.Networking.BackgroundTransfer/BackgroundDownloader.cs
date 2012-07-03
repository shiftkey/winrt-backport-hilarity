using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Networking.BackgroundTransfer
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBackgroundDownloaderStaticMethods), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BackgroundDownloader : IBackgroundDownloader, IBackgroundTransferBase
	{
		public extern BackgroundTransferCostPolicy CostPolicy
		{
			get;
			set;
		}
		public extern string Group
		{
			get;
			set;
		}
		public extern string Method
		{
			get;
			set;
		}
		public extern PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		public extern PasswordCredential ServerCredential
		{
			get;
			set;
		}
		public extern BackgroundDownloader();
		[Overload("CreateDownload")]
		public extern DownloadOperation CreateDownload([In] Uri uri, [In] IStorageFile resultFile);
		[Overload("CreateDownloadFromFile")]
		public extern DownloadOperation CreateDownload([In] Uri uri, [In] IStorageFile resultFile, [In] IStorageFile requestBodyFile);
		public extern IAsyncOperation<DownloadOperation> CreateDownloadAsync([In] Uri uri, [In] IStorageFile resultFile, [In] IInputStream requestBodyStream);
		public extern void SetRequestHeader([In] string headerName, [In] string headerValue);
		[Overload("GetCurrentDownloadsAsync")]
		public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();
		[Overload("GetCurrentDownloadsForGroupAsync")]
		public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync([In] string group);
	}
}
