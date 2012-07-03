using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(2547030181u, 15257, 19945, 136, 165, 225, 29, 47, 80, 199, 149), Version(100794368u)]
	public interface IContentTypeProvider
	{
		string ContentType
		{
			get;
		}
	}
}
