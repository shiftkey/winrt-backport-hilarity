using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(1837385816u, 3327, 17808, 174, 137, 149, 165, 165, 200, 180, 184), Version(100794368u)]
	public delegate void AsyncActionProgressHandler<TProgress>([In] IAsyncActionWithProgress<TProgress> asyncInfo, [In] TProgress progressInfo);
}
