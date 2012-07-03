using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[Version(100794368u)]
	public enum HostNameType
	{
		DomainName,
		Ipv4,
		Ipv6,
		Bluetooth
	}
}
