using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ToastNotification)), Guid(2575181429u, 1438, 20064, 139, 6, 23, 96, 145, 124, 139, 128), Version(100794368u)]
	internal interface IToastNotification
	{
		event TypedEventHandler<ToastNotification, object> Activated;
		event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;
		event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;
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
