using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(BackgroundDownloader)), Guid(1386633781u, 50766, 17004, 153, 25, 84, 13, 13, 33, 166, 80), Version(100794368u)]
	internal interface IBackgroundDownloaderStaticMethods
	{
		[Overload("GetCurrentDownloadsAsync")]
		IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();
		[Overload("GetCurrentDownloadsForGroupAsync")]
		IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync([In] string group);
	}
}
