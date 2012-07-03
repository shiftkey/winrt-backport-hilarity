using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage.Compression
{
	[ExclusiveTo(typeof(Decompressor)), Guid(3095658054u, 54922, 19595, 173, 160, 78, 232, 19, 252, 82, 131), Version(100794368u)]
	internal interface IDecompressor : IInputStream, IClosable
	{
		IInputStream DetachStream();
	}
}
