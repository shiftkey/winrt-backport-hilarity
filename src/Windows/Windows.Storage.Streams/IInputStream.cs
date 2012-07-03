using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(2421821410u, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218), Version(100794368u)]
	public interface IInputStream : IClosable
	{
		IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
	}
}
