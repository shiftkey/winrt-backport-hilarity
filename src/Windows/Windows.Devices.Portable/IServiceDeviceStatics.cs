using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Portable
{
	[ExclusiveTo(typeof(ServiceDevice)), Guid(2827097313u, 22983, 18976, 171, 166, 159, 103, 7, 147, 114, 48), Version(100794368u)]
	internal interface IServiceDeviceStatics
	{
		string GetDeviceSelector([In] ServiceDeviceType serviceType);
		string GetDeviceSelectorFromServiceId([In] Guid serviceId);
	}
}
