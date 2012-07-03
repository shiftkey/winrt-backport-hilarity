using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapEncoder)), Guid(2806208167u, 42212, 20153, 142, 64, 86, 77, 231, 225, 204, 178), Version(100794368u)]
	internal interface IBitmapEncoderStatics
	{
		Guid BmpEncoderId
		{
			get;
		}
		Guid GifEncoderId
		{
			get;
		}
		Guid JpegEncoderId
		{
			get;
		}
		Guid JpegXREncoderId
		{
			get;
		}
		Guid PngEncoderId
		{
			get;
		}
		Guid TiffEncoderId
		{
			get;
		}
		IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator();
		[DefaultOverload, Overload("CreateAsync")]
		IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream);
		[DefaultOverload, Overload("CreateWithEncodingOptionsAsync")]
		IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream, [In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
		IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync([In] IRandomAccessStream stream, [In] BitmapDecoder bitmapDecoder);
		IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync([In] BitmapDecoder bitmapDecoder);
	}
}
