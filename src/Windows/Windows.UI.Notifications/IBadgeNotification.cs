using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(BadgeNotification)), Guid(123516106u, 53386, 20015, 146, 51, 126, 40, 156, 31, 119, 34), Version(100794368u)]
	internal interface IBadgeNotification
	{
		XmlDocument Content
		{
			get;
		}
		IReference<DateTime> ExpirationTime
		{
			get;
			set;
		}
	}
}
