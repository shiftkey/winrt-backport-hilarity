using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class InputStreamOverStream : IInputStream, IClosable
	{
		public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
		public extern void Close();
	}
}
