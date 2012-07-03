using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(TileNotification)), Guid(3333152110u, 18728, 18120, 189, 191, 129, 160, 71, 222, 160, 212), Version(100794368u)]
	internal interface ITileNotificationFactory
	{
		TileNotification CreateTileNotification([In] XmlDocument content);
	}
}
