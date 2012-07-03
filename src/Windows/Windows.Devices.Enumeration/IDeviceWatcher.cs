using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[ExclusiveTo(typeof(DeviceWatcher)), Guid(3387603325u, 36715, 20374, 169, 244, 171, 200, 20, 226, 34, 113), Version(100794368u)]
	internal interface IDeviceWatcher
	{
		event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;
		event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;
		event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;
		event TypedEventHandler<DeviceWatcher, object> Stopped;
		event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;
		DeviceWatcherStatus Status
		{
			get;
		}
		void Start();
		void Stop();
	}
}
