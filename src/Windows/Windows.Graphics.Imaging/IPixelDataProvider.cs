using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(PixelDataProvider)), Guid(3716357925u, 6236, 17813, 159, 185, 204, 190, 110, 193, 138, 111), Version(100794368u)]
	internal interface IPixelDataProvider
	{
		byte[] DetachPixelData();
	}
}
