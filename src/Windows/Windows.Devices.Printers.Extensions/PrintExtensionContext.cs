using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPrintExtensionContextStatic), 100794368u), Version(100794368u)]
	public static class PrintExtensionContext
	{
		public static extern object FromDeviceId([In] string deviceId);
	}
}
