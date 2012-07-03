using System;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;
namespace Windows.Networking.PushNotifications
{
	[Version(100794368u)]
	public sealed class PushNotificationReceivedEventArgs : IPushNotificationReceivedEventArgs
	{
		public extern BadgeNotification BadgeNotification
		{
			get;
		}
		public extern bool Cancel
		{
			get;
			set;
		}
		public extern PushNotificationType NotificationType
		{
			get;
		}
		public extern RawNotification RawNotification
		{
			get;
		}
		public extern TileNotification TileNotification
		{
			get;
		}
		public extern ToastNotification ToastNotification
		{
			get;
		}
	}
}
