using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Portable
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IServiceDeviceStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class ServiceDevice
	{
		public static extern string GetDeviceSelector([In] ServiceDeviceType serviceType);
		public static extern string GetDeviceSelectorFromServiceId([In] Guid serviceId);
	}
}
