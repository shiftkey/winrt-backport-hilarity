using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Activatable(typeof(IToastNotificationFactory), 100794368u), DualApiPartition(version = 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class ToastNotification : IToastNotification
	{
		public extern event TypedEventHandler<ToastNotification, object> Activated
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed
		{
			add;
			remove;
		}
		public extern XmlDocument Content
		{
			get;
		}
		public extern IReference<DateTime> ExpirationTime
		{
			get;
			set;
		}
		public extern ToastNotification([In] XmlDocument content);
	}
}
