using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Activatable(typeof(IScheduledToastNotificationFactory), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class ScheduledToastNotification : IScheduledToastNotification
	{
		public extern XmlDocument Content
		{
			get;
		}
		public extern DateTime DeliveryTime
		{
			get;
		}
		public extern string Id
		{
			get;
			set;
		}
		public extern uint MaximumSnoozeCount
		{
			get;
		}
		public extern IReference<TimeSpan> SnoozeInterval
		{
			get;
		}
		public extern ScheduledToastNotification([In] XmlDocument content, [In] DateTime deliveryTime);
		public extern ScheduledToastNotification([In] XmlDocument content, [In] DateTime deliveryTime, [In] TimeSpan snoozeInterval, [In] uint maximumSnoozeCount);
	}
}
