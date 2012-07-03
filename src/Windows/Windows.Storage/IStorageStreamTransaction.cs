using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(StorageStreamTransaction)), Guid(4135383907u, 42301, 19860, 174, 44, 103, 35, 45, 147, 172, 221), Version(100794368u)]
	internal interface IStorageStreamTransaction : IClosable
	{
		IRandomAccessStream Stream
		{
			get;
		}
		IAsyncAction CommitAsync();
	}
}
