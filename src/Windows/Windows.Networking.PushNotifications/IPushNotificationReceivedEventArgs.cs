using System;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;
namespace Windows.Networking.PushNotifications
{
	[ExclusiveTo(typeof(PushNotificationReceivedEventArgs)), Guid(3506855436u, 14029, 18508, 185, 53, 10, 153, 183, 83, 207, 0), Version(100794368u)]
	internal interface IPushNotificationReceivedEventArgs
	{
		BadgeNotification BadgeNotification
		{
			get;
		}
		bool Cancel
		{
			get;
			set;
		}
		PushNotificationType NotificationType
		{
			get;
		}
		RawNotification RawNotification
		{
			get;
		}
		TileNotification TileNotification
		{
			get;
		}
		ToastNotification ToastNotification
		{
			get;
		}
	}
}
