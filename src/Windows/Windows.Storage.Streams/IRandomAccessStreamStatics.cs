using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(RandomAccessStream)), Guid(1380773327u, 28201, 19685, 149, 115, 107, 117, 61, 182, 108, 58), Version(100794368u)]
	internal interface IRandomAccessStreamStatics
	{
		[Overload("CopyAsync")]
		IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination);
		[Overload("CopySizeAsync")]
		IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination, [In] ulong bytesToCopy);
		IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync([In] IInputStream source, [In] IOutputStream destination);
	}
}
