using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ToastNotificationManager)), Guid(1353453631u, 53813, 17816, 187, 239, 152, 254, 77, 26, 58, 212), Version(100794368u)]
	internal interface IToastNotificationManagerStatics
	{
		[Overload("CreateToastNotifier")]
		ToastNotifier CreateToastNotifier();
		[Overload("CreateToastNotifierWithId")]
		ToastNotifier CreateToastNotifier([In] string applicationId);
		XmlDocument GetTemplateContent([In] ToastTemplateType type);
	}
}
