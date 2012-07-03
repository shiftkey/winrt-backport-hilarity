using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[Static(typeof(IPushNotificationChannelManagerStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class PushNotificationChannelManager
	{
		[Overload("CreatePushNotificationChannelForApplicationAsync")]
		public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();
		[Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
		public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync([In] string applicationId);
		public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync([In] string tileId);
	}
}
