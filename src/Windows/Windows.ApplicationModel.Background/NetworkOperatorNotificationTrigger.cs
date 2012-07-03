using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(typeof(INetworkOperatorNotificationTriggerFactory), 100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class NetworkOperatorNotificationTrigger : INetworkOperatorNotificationTrigger, IBackgroundTrigger
	{
		public extern string NetworkAccountId
		{
			get;
		}
		public extern NetworkOperatorNotificationTrigger([In] string networkAccountId);
	}
}
