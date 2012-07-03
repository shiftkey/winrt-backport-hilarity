using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandAccountWatcher)), Guid(1811100510u, 9141, 17567, 146, 141, 94, 13, 62, 4, 71, 29), Version(100794368u)]
	internal interface IMobileBroadbandAccountWatcher
	{
		event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountAdded;
		event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountRemoved;
		event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> AccountUpdated;
		event TypedEventHandler<MobileBroadbandAccountWatcher, object> EnumerationCompleted;
		event TypedEventHandler<MobileBroadbandAccountWatcher, object> Stopped;
		MobileBroadbandAccountWatcherStatus Status
		{
			get;
		}
		void Start();
		void Stop();
	}
}
