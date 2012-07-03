using System.Runtime.InteropServices;
using Windows.Foundation;

namespace Windows.Storage.Streams
{
	public interface IInputStream : IClosable
	{
		IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
	}
}
