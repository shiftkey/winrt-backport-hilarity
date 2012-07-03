using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRandomAccessStreamStatics), 100794368u), Version(100794368u)]
	public static class RandomAccessStream
	{
		[Overload("CopyAsync")]
		public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination);
		[Overload("CopySizeAsync")]
		public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination, [In] ulong bytesToCopy);
		public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync([In] IInputStream source, [In] IOutputStream destination);
	}
}
