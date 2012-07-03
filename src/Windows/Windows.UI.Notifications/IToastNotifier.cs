using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ToastNotifier)), Guid(1972534163u, 1011, 16876, 145, 211, 110, 91, 172, 27, 56, 231), Version(100794368u)]
	internal interface IToastNotifier
	{
		NotificationSetting Setting
		{
			get;
		}
		void Show([In] ToastNotification notification);
		void Hide([In] ToastNotification notification);
		void AddToSchedule([In] ScheduledToastNotification scheduledToast);
		void RemoveFromSchedule([In] ScheduledToastNotification scheduledToast);
		IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();
	}
}
