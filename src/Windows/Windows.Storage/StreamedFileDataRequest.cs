using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[Version(100794368u)]
	public sealed class StreamedFileDataRequest : IOutputStream, IClosable, IStreamedFileDataRequest
	{
		public extern IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
		public extern IAsyncOperation<bool> FlushAsync();
		public extern void Close();
		public extern void FailAndClose([In] StreamedFileFailureMode failureMode);
	}
}
