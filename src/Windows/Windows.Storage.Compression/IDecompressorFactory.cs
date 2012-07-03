using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage.Compression
{
	[ExclusiveTo(typeof(Decompressor)), Guid(1396171346u, 7586, 17121, 136, 52, 3, 121, 210, 141, 116, 47), Version(100794368u)]
	internal interface IDecompressorFactory
	{
		Decompressor CreateDecompressor([In] IInputStream underlyingStream);
	}
}
