using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(2648818996u, 27361, 4576, 132, 225, 24, 169, 5, 188, 197, 63), Version(100794368u)]
	public delegate void TypedEventHandler<TSender, TResult>([In] TSender sender, [In] TResult args);
}
