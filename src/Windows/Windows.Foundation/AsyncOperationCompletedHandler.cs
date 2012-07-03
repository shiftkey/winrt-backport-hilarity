using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(4242337836u, 58840, 17528, 145, 90, 77, 144, 183, 75, 131, 165), Version(100794368u)]
	public delegate void AsyncOperationCompletedHandler<TResult>([In] IAsyncOperation<TResult> asyncInfo, [In] AsyncStatus asyncStatus);
}
