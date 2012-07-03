using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Networking.BackgroundTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DownloadOperation : IDownloadOperation, IBackgroundTransferOperation
	{
		public extern BackgroundDownloadProgress Progress
		{
			get;
		}
		public extern IStorageFile ResultFile
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
		public extern IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();
		public extern IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();
		public extern void Pause();
		public extern void Resume();
		public extern IInputStream GetResultStreamAt([In] ulong position);
		public extern ResponseInformation GetResponseInformation();
	}
}
