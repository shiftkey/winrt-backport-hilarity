using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(100794368u), Activatable(typeof(IPushNotificationTriggerFactory), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class PushNotificationTrigger : IBackgroundTrigger
	{
		public extern PushNotificationTrigger([In] string applicationId);
		public extern PushNotificationTrigger();
	}
}
