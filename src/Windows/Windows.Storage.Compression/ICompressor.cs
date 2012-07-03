using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage.Compression
{
	[ExclusiveTo(typeof(Compressor)), Guid(180577370u, 22444, 20193, 183, 2, 132, 211, 157, 84, 36, 224), Version(100794368u)]
	internal interface ICompressor : IOutputStream, IClosable
	{
		IAsyncOperation<bool> FinishAsync();
		IOutputStream DetachStream();
	}
}
