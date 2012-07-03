using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class ToastNotifier : IToastNotifier
	{
		public extern NotificationSetting Setting
		{
			get;
		}
		public extern void Show([In] ToastNotification notification);
		public extern void Hide([In] ToastNotification notification);
		public extern void AddToSchedule([In] ScheduledToastNotification scheduledToast);
		public extern void RemoveFromSchedule([In] ScheduledToastNotification scheduledToast);
		public extern IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();
	}
}
