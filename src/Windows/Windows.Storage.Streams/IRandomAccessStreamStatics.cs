using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(RandomAccessStream))]
	internal interface IRandomAccessStreamStatics
	{
		[Overload("CopyAsync")]
		IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination);
		[Overload("CopySizeAsync")]
		IAsyncOperationWithProgress<ulong, ulong> CopyAsync([In] IInputStream source, [In] IOutputStream destination, [In] ulong bytesToCopy);
		IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync([In] IInputStream source, [In] IOutputStream destination);
	}
}
