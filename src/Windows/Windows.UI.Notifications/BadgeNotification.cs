using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Activatable(typeof(IBadgeNotificationFactory), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class BadgeNotification : IBadgeNotification
	{
		public extern XmlDocument Content
		{
			get;
		}
		public extern IReference<DateTime> ExpirationTime
		{
			get;
			set;
		}
		public extern BadgeNotification([In] XmlDocument content);
	}
}
