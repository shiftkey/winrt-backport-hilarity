using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(1432946946u, 2731, 16922, 135, 120, 248, 206, 80, 38, 215, 88), Version(100794368u)]
	public delegate void AsyncOperationProgressHandler<TResult, TProgress>([In] IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, [In] TProgress progressInfo);
}
