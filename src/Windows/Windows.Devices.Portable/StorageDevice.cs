using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Devices.Portable
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IStorageDeviceStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class StorageDevice
	{
		public static extern StorageFolder FromId([In] string interfaceId);
		public static extern string GetDeviceSelector();
	}
}
