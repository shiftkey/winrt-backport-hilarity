using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(2421821414u, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218), Version(100794368u)]
	public interface IOutputStream : IClosable
	{
		IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
		IAsyncOperation<bool> FlushAsync();
	}
}
