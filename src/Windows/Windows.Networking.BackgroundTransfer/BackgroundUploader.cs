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
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBackgroundUploaderStaticMethods), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BackgroundUploader : IBackgroundUploader, IBackgroundTransferBase
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
		public extern BackgroundUploader();
		public extern UploadOperation CreateUpload([In] Uri uri, [In] IStorageFile sourceFile);
		public extern IAsyncOperation<UploadOperation> CreateUploadFromStreamAsync([In] Uri uri, [In] IInputStream sourceStream);
		[Overload("CreateUploadWithFormDataAndAutoBoundaryAsync")]
		public extern IAsyncOperation<UploadOperation> CreateUploadAsync([In] Uri uri, [In] IIterable<BackgroundTransferContentPart> parts);
		[Overload("CreateUploadWithSubTypeAsync")]
		public extern IAsyncOperation<UploadOperation> CreateUploadAsync([In] Uri uri, [In] IIterable<BackgroundTransferContentPart> parts, [In] string subType);
		[Overload("CreateUploadWithSubTypeAndBoundaryAsync")]
		public extern IAsyncOperation<UploadOperation> CreateUploadAsync([In] Uri uri, [In] IIterable<BackgroundTransferContentPart> parts, [In] string subType, [In] string boundary);
		public extern void SetRequestHeader([In] string headerName, [In] string headerValue);
		[Overload("GetCurrentUploadsAsync")]
		public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();
		[Overload("GetCurrentUploadsForGroupAsync")]
		public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync([In] string group);
	}
}
