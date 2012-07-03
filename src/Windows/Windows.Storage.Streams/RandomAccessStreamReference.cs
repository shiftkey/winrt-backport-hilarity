using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRandomAccessStreamReferenceStatics), 100794368u), Version(100794368u)]
	public sealed class RandomAccessStreamReference : IRandomAccessStreamReference
	{
		public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
		public static extern RandomAccessStreamReference CreateFromFile([In] IStorageFile file);
		public static extern RandomAccessStreamReference CreateFromUri([In] Uri uri);
		public static extern RandomAccessStreamReference CreateFromStream([In] IRandomAccessStream stream);
	}
}
