using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ScheduledTileNotification)), Guid(180135637u, 39388, 19576, 161, 28, 201, 231, 248, 109, 126, 247), Version(100794368u)]
	internal interface IScheduledTileNotification
	{
		XmlDocument Content
		{
			get;
		}
		DateTime DeliveryTime
		{
			get;
		}
		IReference<DateTime> ExpirationTime
		{
			get;
			set;
		}
		string Id
		{
			get;
			set;
		}
		string Tag
		{
			get;
			set;
		}
	}
}
