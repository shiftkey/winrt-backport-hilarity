using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class NetworkOperatorHotspotAuthenticationTrigger : INetworkOperatorHotspotAuthenticationTrigger, IBackgroundTrigger
	{
		public extern NetworkOperatorHotspotAuthenticationTrigger();
	}
}
