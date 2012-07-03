using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(DownloadOperation)), Guid(3179801520u, 22292, 19977, 186, 104, 190, 247, 57, 3, 176, 215), Version(100794368u)]
	internal interface IDownloadOperation : IBackgroundTransferOperation
	{
		BackgroundDownloadProgress Progress
		{
			get;
		}
		IStorageFile ResultFile
		{
			get;
		}
		IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();
		IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();
		void Pause();
		void Resume();
	}
}
