using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(2767019137u, 30409, 16573, 139, 230, 177, 217, 15, 178, 10, 231), Version(100794368u)]
	public delegate void AsyncActionCompletedHandler([In] IAsyncAction asyncInfo, [In] AsyncStatus asyncStatus);
}
