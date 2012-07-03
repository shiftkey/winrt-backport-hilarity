using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage.Compression
{
	[ExclusiveTo(typeof(Compressor)), Guid(1597871780u, 11515, 17452, 168, 186, 215, 209, 27, 3, 157, 160), Version(100794368u)]
	internal interface ICompressorFactory
	{
		Compressor CreateCompressor([In] IOutputStream underlyingStream);
		Compressor CreateCompressorEx([In] IOutputStream underlyingStream, [In] CompressAlgorithm algorithm, [In] uint blockSize);
	}
}
