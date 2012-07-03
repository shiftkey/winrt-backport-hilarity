using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[Version(100794368u)]
	public sealed class StorageStreamTransaction : IStorageStreamTransaction, IClosable
	{
		public extern IRandomAccessStream Stream
		{
			get;
		}
		public extern IAsyncAction CommitAsync();
		public extern void Close();
	}
}
