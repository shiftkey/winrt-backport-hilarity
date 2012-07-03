using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Activatable(typeof(ITileNotificationFactory), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class TileNotification : ITileNotification
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
		public extern string Tag
		{
			get;
			set;
		}
		public extern TileNotification([In] XmlDocument content);
	}
}
