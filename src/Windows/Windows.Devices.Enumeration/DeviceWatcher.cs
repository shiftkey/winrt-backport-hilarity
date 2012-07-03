using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DeviceWatcher : IDeviceWatcher
	{
		public extern event TypedEventHandler<DeviceWatcher, DeviceInformation> Added
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<DeviceWatcher, object> Stopped
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated
		{
			add;
			remove;
		}
		public extern DeviceWatcherStatus Status
		{
			get;
		}
		public extern void Start();
		public extern void Stop();
	}
}
