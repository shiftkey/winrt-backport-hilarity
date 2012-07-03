using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(BadgeUpdateManager)), Guid(859836330u, 28117, 16645, 174, 188, 155, 80, 252, 164, 146, 218), Version(100794368u)]
	internal interface IBadgeUpdateManagerStatics
	{
		[Overload("CreateBadgeUpdaterForApplication")]
		BadgeUpdater CreateBadgeUpdaterForApplication();
		[Overload("CreateBadgeUpdaterForApplicationWithId")]
		BadgeUpdater CreateBadgeUpdaterForApplication([In] string applicationId);
		BadgeUpdater CreateBadgeUpdaterForSecondaryTile([In] string tileId);
		XmlDocument GetTemplateContent([In] BadgeTemplateType type);
	}
}
