using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DeviceInformationUpdate : IDeviceInformationUpdate
	{
		public extern string Id
		{
			get;
		}
		public extern IMapView<string, object> Properties
		{
			[return: HasVariant]
			get;
		}
	}
}
