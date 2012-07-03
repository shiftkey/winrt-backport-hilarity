using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ToastNotification)), Guid(68307744u, 33478, 16937, 177, 9, 253, 158, 212, 102, 43, 83), Version(100794368u)]
	internal interface IToastNotificationFactory
	{
		ToastNotification CreateToastNotification([In] XmlDocument content);
	}
}
