using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(TileUpdateManager)), Guid(3658849885u, 16041, 18822, 141, 132, 176, 157, 94, 18, 39, 109), Version(100794368u)]
	internal interface ITileUpdateManagerStatics
	{
		[Overload("CreateTileUpdaterForApplication")]
		TileUpdater CreateTileUpdaterForApplication();
		[Overload("CreateTileUpdaterForApplicationWithId")]
		TileUpdater CreateTileUpdaterForApplication([In] string applicationId);
		TileUpdater CreateTileUpdaterForSecondaryTile([In] string tileId);
		XmlDocument GetTemplateContent([In] TileTemplateType type);
	}
}
