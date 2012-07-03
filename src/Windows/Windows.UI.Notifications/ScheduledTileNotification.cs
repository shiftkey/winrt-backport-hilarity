using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Activatable(typeof(IScheduledTileNotificationFactory), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class ScheduledTileNotification : IScheduledTileNotification
	{
		public extern XmlDocument Content
		{
			get;
		}
		public extern DateTime DeliveryTime
		{
			get;
		}
		public extern IReference<DateTime> ExpirationTime
		{
			get;
			set;
		}
		public extern string Id
		{
			get;
			set;
		}
		public extern string Tag
		{
			get;
			set;
		}
		public extern ScheduledTileNotification([In] XmlDocument content, [In] DateTime deliveryTime);
	}
}
