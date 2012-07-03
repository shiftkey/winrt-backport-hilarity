using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(BackgroundUploader)), Guid(3314928046u, 52909, 18011, 136, 1, 197, 90, 201, 10, 1, 206), Version(100794368u)]
	internal interface IBackgroundUploader : IBackgroundTransferBase
	{
		UploadOperation CreateUpload([In] Uri uri, [In] IStorageFile sourceFile);
		IAsyncOperation<UploadOperation> CreateUploadFromStreamAsync([In] Uri uri, [In] IInputStream sourceStream);
		[Overload("CreateUploadWithFormDataAndAutoBoundaryAsync")]
		IAsyncOperation<UploadOperation> CreateUploadAsync([In] Uri uri, [In] IIterable<BackgroundTransferContentPart> parts);
		[Overload("CreateUploadWithSubTypeAsync")]
		IAsyncOperation<UploadOperation> CreateUploadAsync([In] Uri uri, [In] IIterable<BackgroundTransferContentPart> parts, [In] string subType);
		[Overload("CreateUploadWithSubTypeAndBoundaryAsync")]
		IAsyncOperation<UploadOperation> CreateUploadAsync([In] Uri uri, [In] IIterable<BackgroundTransferContentPart> parts, [In] string subType, [In] string boundary);
	}
}
