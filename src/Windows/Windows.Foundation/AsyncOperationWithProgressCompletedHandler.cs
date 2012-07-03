using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(3898471453u, 27303, 18147, 168, 226, 240, 9, 216, 64, 198, 39), Version(100794368u)]
	public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>([In] IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, [In] AsyncStatus asyncStatus);
}
