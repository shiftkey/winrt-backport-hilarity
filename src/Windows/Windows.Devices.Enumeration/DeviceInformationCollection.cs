using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DeviceInformationCollection : IVectorView<DeviceInformation>, IIterable<DeviceInformation>
	{
		public extern uint Size
		{
			get;
		}
		public extern DeviceInformation GetAt([In] uint index);
		public extern bool IndexOf([In] DeviceInformation value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] DeviceInformation[] items);
		public extern IIterator<DeviceInformation> First();
	}
}
