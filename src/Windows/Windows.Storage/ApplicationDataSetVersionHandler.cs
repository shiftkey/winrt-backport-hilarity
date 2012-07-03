using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Guid(2690093542u, 52383, 18055, 172, 171, 163, 100, 253, 120, 84, 99), Version(100794368u)]
	public delegate void ApplicationDataSetVersionHandler([In] SetVersionRequest setVersionRequest);
}
