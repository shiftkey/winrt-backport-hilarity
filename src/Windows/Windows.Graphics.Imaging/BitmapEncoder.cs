using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Graphics.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBitmapEncoderStatics), 100794368u), Version(100794368u)]
	public sealed class BitmapEncoder : IBitmapEncoder
	{
		public extern BitmapProperties BitmapContainerProperties
		{
			get;
		}
		public extern BitmapProperties BitmapProperties
		{
			get;
		}
		public extern BitmapTransform BitmapTransform
		{
			get;
		}
		public extern BitmapCodecInformation EncoderInformation
		{
			get;
		}
		public extern uint GeneratedThumbnailHeight
		{
			get;
			set;
		}
		public extern uint GeneratedThumbnailWidth
		{
			get;
			set;
		}
		public extern bool IsThumbnailGenerated
		{
			get;
			set;
		}
		public static extern Guid BmpEncoderId
		{
			get;
		}
		public static extern Guid GifEncoderId
		{
			get;
		}
		public static extern Guid JpegEncoderId
		{
			get;
		}
		public static extern Guid JpegXREncoderId
		{
			get;
		}
		public static extern Guid PngEncoderId
		{
			get;
		}
		public static extern Guid TiffEncoderId
		{
			get;
		}
		public extern void SetPixelData([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] uint width, [In] uint height, [In] double dpiX, [In] double dpiY, [Range(0, 2147483647)] [In] byte[] pixels);
		[DefaultOverload, Overload("GoToNextFrameAsync")]
		public extern IAsyncAction GoToNextFrameAsync();
		[DefaultOverload, Overload("GoToNextFrameWithEncodingOptionsAsync")]
		public extern IAsyncAction GoToNextFrameAsync([In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
		public extern IAsyncAction FlushAsync();
		public static extern IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator();
		[DefaultOverload, Overload("CreateAsync")]
		public static extern IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream);
		[DefaultOverload, Overload("CreateWithEncodingOptionsAsync")]
		public static extern IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream, [In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
		public static extern IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync([In] IRandomAccessStream stream, [In] BitmapDecoder bitmapDecoder);
		public static extern IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync([In] BitmapDecoder bitmapDecoder);
	}
}
