using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[ExclusiveTo(typeof(PrintExtensionContext)), Guid(3876429761u, 65401, 19108, 140, 155, 12, 147, 174, 223, 222, 138), Version(100794368u)]
	internal interface IPrintExtensionContextStatic
	{
		object FromDeviceId([In] string deviceId);
	}
}
