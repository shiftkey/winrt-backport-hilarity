using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(1133681944u, 24265, 19290, 145, 156, 66, 5, 176, 200, 4, 182), Version(100794368u)]
	public interface IInputStreamReference
	{
		IAsyncOperation<IInputStream> OpenSequentialReadAsync();
	}
}
