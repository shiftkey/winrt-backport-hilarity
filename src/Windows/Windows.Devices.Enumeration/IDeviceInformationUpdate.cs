using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[ExclusiveTo(typeof(DeviceInformationUpdate)), Guid(2402374405u, 55666, 17591, 163, 126, 158, 130, 44, 120, 33, 59), Version(100794368u)]
	internal interface IDeviceInformationUpdate
	{
		string Id
		{
			get;
		}
		IMapView<string, object> Properties
		{
			[return: HasVariant]
			get;
		}
	}
}
