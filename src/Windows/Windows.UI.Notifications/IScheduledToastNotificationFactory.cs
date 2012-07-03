using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ScheduledToastNotification)), Guid(3888042385u, 3001, 16777, 131, 148, 49, 118, 27, 71, 111, 215), Version(100794368u)]
	internal interface IScheduledToastNotificationFactory
	{
		[Overload("CreateScheduledToastNotification")]
		ScheduledToastNotification CreateScheduledToastNotification([In] XmlDocument content, [In] DateTime deliveryTime);
		[Overload("CreateScheduledToastNotificationRecurring")]
		ScheduledToastNotification CreateScheduledToastNotification([In] XmlDocument content, [In] DateTime deliveryTime, [In] TimeSpan snoozeInterval, [In] uint maximumSnoozeCount);
	}
}
