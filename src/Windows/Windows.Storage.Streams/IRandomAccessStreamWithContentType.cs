using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(3424995367u, 19261, 17295, 146, 50, 16, 199, 107, 199, 224, 56), Version(100794368u)]
	public interface IRandomAccessStreamWithContentType : IRandomAccessStream, IClosable, IInputStream, IOutputStream, IContentTypeProvider
	{
	}
}
