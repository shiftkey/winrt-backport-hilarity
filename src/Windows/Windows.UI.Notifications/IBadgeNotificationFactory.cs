using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(BadgeNotification)), Guid(3992081870u, 1560, 19801, 148, 138, 90, 97, 4, 12, 82, 249), Version(100794368u)]
	internal interface IBadgeNotificationFactory
	{
		BadgeNotification CreateBadgeNotification([In] XmlDocument content);
	}
}
