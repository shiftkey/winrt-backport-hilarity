using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage.Compression
{
	[Activatable(typeof(IDecompressorFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class Decompressor : IDecompressor, IInputStream, IClosable
	{
		public extern Decompressor([In] IInputStream underlyingStream);
		public extern IInputStream DetachStream();
		public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
		public extern void Close();
	}
}
