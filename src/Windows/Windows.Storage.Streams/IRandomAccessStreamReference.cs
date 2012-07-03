using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(871248180u, 7638, 20026, 128, 103, 209, 193, 98, 232, 100, 43), Version(100794368u)]
	public interface IRandomAccessStreamReference
	{
		IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
	}
}
