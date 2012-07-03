using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(UploadOperation)), Guid(1045832928u, 29577, 17228, 139, 53, 66, 127, 211, 107, 189, 174), Version(100794368u)]
	internal interface IUploadOperation : IBackgroundTransferOperation
	{
		BackgroundUploadProgress Progress
		{
			get;
		}
		IStorageFile SourceFile
		{
			get;
		}
		IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();
		IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();
	}
}
