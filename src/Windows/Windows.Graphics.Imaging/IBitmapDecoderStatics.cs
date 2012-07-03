using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapDecoder)), Guid(1133300518u, 48367, 20117, 186, 214, 35, 168, 34, 229, 141, 1), Version(100794368u)]
	internal interface IBitmapDecoderStatics
	{
		Guid BmpDecoderId
		{
			get;
		}
		Guid GifDecoderId
		{
			get;
		}
		Guid IcoDecoderId
		{
			get;
		}
		Guid JpegDecoderId
		{
			get;
		}
		Guid JpegXRDecoderId
		{
			get;
		}
		Guid PngDecoderId
		{
			get;
		}
		Guid TiffDecoderId
		{
			get;
		}
		IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator();
		[DefaultOverload, Overload("CreateAsync")]
		IAsyncOperation<BitmapDecoder> CreateAsync([In] IRandomAccessStream stream);
		[DefaultOverload, Overload("CreateWithIdAsync")]
		IAsyncOperation<BitmapDecoder> CreateAsync([In] Guid decoderId, [In] IRandomAccessStream stream);
	}
}
