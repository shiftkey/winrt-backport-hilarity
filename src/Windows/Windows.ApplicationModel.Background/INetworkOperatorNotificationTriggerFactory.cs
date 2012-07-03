using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(NetworkOperatorNotificationTrigger)), Guid(170016256u, 10199, 17235, 173, 185, 146, 101, 170, 234, 87, 157), Version(100794368u)]
	internal interface INetworkOperatorNotificationTriggerFactory
	{
		NetworkOperatorNotificationTrigger Create([In] string networkAccountId);
	}
}
