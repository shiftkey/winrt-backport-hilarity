using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Static(typeof(ITileUpdateManagerStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class TileUpdateManager
	{
		[Overload("CreateTileUpdaterForApplication")]
		public static extern TileUpdater CreateTileUpdaterForApplication();
		[Overload("CreateTileUpdaterForApplicationWithId")]
		public static extern TileUpdater CreateTileUpdaterForApplication([In] string applicationId);
		public static extern TileUpdater CreateTileUpdaterForSecondaryTile([In] string tileId);
		public static extern XmlDocument GetTemplateContent([In] TileTemplateType type);
	}
}
