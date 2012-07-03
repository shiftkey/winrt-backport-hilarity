using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[Version(100794368u)]
	public enum PnpObjectType
	{
		Unknown,
		DeviceInterface,
		DeviceContainer,
		Device,
		DeviceInterfaceClass
	}
}
