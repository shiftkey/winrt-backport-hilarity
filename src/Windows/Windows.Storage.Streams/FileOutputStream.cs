using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class FileOutputStream : IOutputStream, IClosable
	{
		public extern IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
		public extern IAsyncOperation<bool> FlushAsync();
		public extern void Close();
	}
}
