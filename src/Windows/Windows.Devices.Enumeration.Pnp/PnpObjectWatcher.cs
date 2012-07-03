using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PnpObjectWatcher : IPnpObjectWatcher
	{
		public extern event TypedEventHandler<PnpObjectWatcher, PnpObject> Added
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PnpObjectWatcher, object> Stopped
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated
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
