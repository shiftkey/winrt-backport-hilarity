using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[ExclusiveTo(typeof(PushNotificationChannelManager)), Guid(2343541605u, 30625, 17800, 189, 25, 134, 21, 41, 169, 220, 240), Version(100794368u)]
	internal interface IPushNotificationChannelManagerStatics
	{
		[Overload("CreatePushNotificationChannelForApplicationAsync")]
		IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();
		[Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
		IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync([In] string applicationId);
		IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync([In] string tileId);
	}
}
