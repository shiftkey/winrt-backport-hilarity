using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(2617417617u, 52356, 17661, 172, 38, 10, 108, 78, 85, 82, 129), Version(100794368u)]
	public delegate void AsyncActionWithProgressCompletedHandler<TProgress>([In] IAsyncActionWithProgress<TProgress> asyncInfo, [In] AsyncStatus asyncStatus);
}
