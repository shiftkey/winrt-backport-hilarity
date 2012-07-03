using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.StartScreen
{
	[ExclusiveTo(typeof(SecondaryTile)), Guid(1475685536u, 20924, 19135, 142, 191, 98, 122, 3, 152, 176, 90), Version(100794368u)]
	internal interface ISecondaryTileFactory
	{
		SecondaryTile CreateTile([In] string tileId, [In] string shortName, [In] string displayName, [In] string arguments, [In] TileOptions tileOptions, [In] Uri logoReference);
		SecondaryTile CreateWideTile([In] string tileId, [In] string shortName, [In] string displayName, [In] string arguments, [In] TileOptions tileOptions, [In] Uri logoReference, [In] Uri wideLogoReference);
		SecondaryTile CreateWithId([In] string tileId);
	}
}
