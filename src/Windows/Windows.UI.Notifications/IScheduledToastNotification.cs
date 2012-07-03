using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ScheduledToastNotification)), Guid(2046130168u, 3559, 18637, 151, 64, 155, 55, 4, 144, 200, 56), Version(100794368u)]
	internal interface IScheduledToastNotification
	{
		XmlDocument Content
		{
			get;
		}
		DateTime DeliveryTime
		{
			get;
		}
		string Id
		{
			get;
			set;
		}
		uint MaximumSnoozeCount
		{
			get;
		}
		IReference<TimeSpan> SnoozeInterval
		{
			get;
		}
	}
}
