using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[Version(100794368u)]
	public enum DeviceClass
	{
		All,
		AudioCapture,
		AudioRender,
		PortableStorageDevice,
		VideoCapture
	}
}
