using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Guid(4277577764u, 12257, 19719, 163, 91, 183, 124, 80, 181, 244, 204), Version(100794368u)]
	public delegate void StreamedFileDataRequestedHandler([In] StreamedFileDataRequest stream);
}
