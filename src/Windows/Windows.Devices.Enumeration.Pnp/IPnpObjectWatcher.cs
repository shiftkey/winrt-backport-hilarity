using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[ExclusiveTo(typeof(PnpObjectWatcher)), Guid(2211011752u, 18290, 19066, 172, 168, 228, 140, 66, 168, 156, 68), Version(100794368u)]
	internal interface IPnpObjectWatcher
	{
		event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;
		event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;
		event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;
		event TypedEventHandler<PnpObjectWatcher, object> Stopped;
		event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;
		DeviceWatcherStatus Status
		{
			get;
		}
		void Start();
		void Stop();
	}
}
