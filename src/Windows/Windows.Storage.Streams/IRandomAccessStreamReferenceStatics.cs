using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(RandomAccessStreamReference)), Guid(2238908892u, 16319, 20093, 152, 111, 239, 59, 26, 7, 169, 100), Version(100794368u)]
	internal interface IRandomAccessStreamReferenceStatics
	{
		RandomAccessStreamReference CreateFromFile([In] IStorageFile file);
		RandomAccessStreamReference CreateFromUri([In] Uri uri);
		RandomAccessStreamReference CreateFromStream([In] IRandomAccessStream stream);
	}
}
