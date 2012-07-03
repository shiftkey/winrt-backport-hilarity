using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[ExclusiveTo(typeof(HostName)), Guid(4136424639u, 41864, 20107, 145, 234, 84, 221, 109, 217, 1, 192), Version(100794368u)]
	internal interface IHostNameStatics
	{
		int Compare([In] string value1, [In] string value2);
	}
}
