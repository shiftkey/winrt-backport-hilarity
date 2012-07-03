using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[ExclusiveTo(typeof(HostName)), Guid(1166812141u, 28975, 17782, 173, 241, 194, 11, 44, 100, 53, 88), Version(100794368u)]
	internal interface IHostNameFactory
	{
		HostName CreateHostName([In] string hostName);
	}
}
