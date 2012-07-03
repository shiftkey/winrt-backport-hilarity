using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Static(typeof(IBadgeUpdateManagerStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class BadgeUpdateManager
	{
		[Overload("CreateBadgeUpdaterForApplication")]
		public static extern BadgeUpdater CreateBadgeUpdaterForApplication();
		[Overload("CreateBadgeUpdaterForApplicationWithId")]
		public static extern BadgeUpdater CreateBadgeUpdaterForApplication([In] string applicationId);
		public static extern BadgeUpdater CreateBadgeUpdaterForSecondaryTile([In] string tileId);
		public static extern XmlDocument GetTemplateContent([In] BadgeTemplateType type);
	}
}
