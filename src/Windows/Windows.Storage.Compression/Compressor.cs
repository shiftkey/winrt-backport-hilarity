using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage.Compression
{
	[Activatable(typeof(ICompressorFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class Compressor : ICompressor, IOutputStream, IClosable
	{
		public extern Compressor([In] IOutputStream underlyingStream);
		public extern Compressor([In] IOutputStream underlyingStream, [In] CompressAlgorithm algorithm, [In] uint blockSize);
		public extern IAsyncOperation<bool> FinishAsync();
		public extern IOutputStream DetachStream();
		public extern IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
		public extern IAsyncOperation<bool> FlushAsync();
		public extern void Close();
	}
}
