using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.StartScreen
{
	[ExclusiveTo(typeof(SecondaryTile)), Guid(2576387502u, 53329, 18038, 135, 254, 158, 194, 66, 216, 60, 116), Version(100794368u)]
	internal interface ISecondaryTileStatics
	{
		bool Exists([In] string tileId);
		[DefaultOverload, Overload("FindAllAsync")]
		IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();
		[DefaultOverload, Overload("FindAllForApplicationAsync")]
		IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync([In] string applicationId);
		IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
	}
}
