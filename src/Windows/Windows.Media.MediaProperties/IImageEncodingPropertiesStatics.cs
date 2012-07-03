using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(ImageEncodingProperties)), Guid(628910300u, 35737, 17310, 170, 89, 145, 58, 54, 22, 18, 151), Version(100794368u)]
	internal interface IImageEncodingPropertiesStatics
	{
		ImageEncodingProperties CreateJpeg();
		ImageEncodingProperties CreatePng();
		ImageEncodingProperties CreateJpegXR();
	}
}
