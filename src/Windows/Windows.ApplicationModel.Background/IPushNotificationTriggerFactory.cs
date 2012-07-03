using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(PushNotificationTrigger)), Guid(1842933019u, 17806, 20418, 188, 46, 213, 102, 79, 119, 237, 25), Version(100794368u)]
	internal interface IPushNotificationTriggerFactory
	{
		PushNotificationTrigger Create([In] string applicationId);
	}
}
