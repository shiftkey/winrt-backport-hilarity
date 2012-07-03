using System.Runtime.InteropServices;
using Windows.Foundation;

namespace Windows.Storage.Streams
{
	public interface IOutputStream : IClosable
	{
		IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
		IAsyncOperation<bool> FlushAsync();
	}
}
