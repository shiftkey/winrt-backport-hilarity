using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ScheduledTileNotification)), Guid(864228234u, 39104, 19515, 187, 214, 74, 99, 60, 124, 252, 41), Version(100794368u)]
	internal interface IScheduledTileNotificationFactory
	{
		ScheduledTileNotification CreateScheduledTileNotification([In] XmlDocument content, [In] DateTime deliveryTime);
	}
}
