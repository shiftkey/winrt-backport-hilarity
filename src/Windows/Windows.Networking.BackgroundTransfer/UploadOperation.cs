using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Networking.BackgroundTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class UploadOperation : IUploadOperation, IBackgroundTransferOperation
	{
		public extern BackgroundUploadProgress Progress
		{
			get;
		}
		public extern IStorageFile SourceFile
		{
			get;
		}
		public extern BackgroundTransferCostPolicy CostPolicy
		{
			get;
			set;
		}
		public extern string Group
		{
			get;
		}
		public extern Guid Guid
		{
			get;
		}
		public extern string Method
		{
			get;
		}
		public extern Uri RequestedUri
		{
			get;
		}
		public extern IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();
		public extern IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();
		public extern IInputStream GetResultStreamAt([In] ulong position);
		public extern ResponseInformation GetResponseInformation();
	}
}
