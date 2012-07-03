using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[DualApiPartition(version = 100794368u), Static(typeof(IToastNotificationManagerStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class ToastNotificationManager
	{
		[Overload("CreateToastNotifier")]
		public static extern ToastNotifier CreateToastNotifier();
		[Overload("CreateToastNotifierWithId")]
		public static extern ToastNotifier CreateToastNotifier([In] string applicationId);
		public static extern XmlDocument GetTemplateContent([In] ToastTemplateType type);
	}
}
