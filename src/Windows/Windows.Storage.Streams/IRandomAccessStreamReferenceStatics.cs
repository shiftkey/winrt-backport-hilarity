using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(RandomAccessStreamReference))]
	internal interface IRandomAccessStreamReferenceStatics
	{
		RandomAccessStreamReference CreateFromFile([In] IStorageFile file);
		RandomAccessStreamReference CreateFromUri([In] Uri uri);
		RandomAccessStreamReference CreateFromStream([In] IRandomAccessStream stream);
	}
}
