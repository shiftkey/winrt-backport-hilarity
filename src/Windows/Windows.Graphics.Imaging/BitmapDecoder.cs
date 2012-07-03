using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Graphics.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBitmapDecoderStatics), 100794368u), Version(100794368u)]
	public sealed class BitmapDecoder : IBitmapDecoder, IBitmapFrame
	{
		public extern BitmapPropertiesView BitmapContainerProperties
		{
			get;
		}
		public extern BitmapCodecInformation DecoderInformation
		{
			get;
		}
		public extern uint FrameCount
		{
			get;
		}
		public extern BitmapAlphaMode BitmapAlphaMode
		{
			get;
		}
		public extern BitmapPixelFormat BitmapPixelFormat
		{
			get;
		}
		public extern BitmapPropertiesView BitmapProperties
		{
			get;
		}
		public extern double DpiX
		{
			get;
		}
		public extern double DpiY
		{
			get;
		}
		public extern uint OrientedPixelHeight
		{
			get;
		}
		public extern uint OrientedPixelWidth
		{
			get;
		}
		public extern uint PixelHeight
		{
			get;
		}
		public extern uint PixelWidth
		{
			get;
		}
		public static extern Guid BmpDecoderId
		{
			get;
		}
		public static extern Guid GifDecoderId
		{
			get;
		}
		public static extern Guid IcoDecoderId
		{
			get;
		}
		public static extern Guid JpegDecoderId
		{
			get;
		}
		public static extern Guid JpegXRDecoderId
		{
			get;
		}
		public static extern Guid PngDecoderId
		{
			get;
		}
		public static extern Guid TiffDecoderId
		{
			get;
		}
		public extern IAsyncOperation<ImageStream> GetPreviewAsync();
		public extern IAsyncOperation<BitmapFrame> GetFrameAsync([In] uint frameIndex);
		public extern IAsyncOperation<ImageStream> GetThumbnailAsync();
		[DefaultOverload, Overload("GetPixelDataAsync")]
		public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync();
		[DefaultOverload, Overload("GetPixelDataTransformedAsync")]
		public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] BitmapTransform transform, [In] ExifOrientationMode exifOrientationMode, [In] ColorManagementMode colorManagementMode);
		public static extern IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator();
		[DefaultOverload, Overload("CreateAsync")]
		public static extern IAsyncOperation<BitmapDecoder> CreateAsync([In] IRandomAccessStream stream);
		[DefaultOverload, Overload("CreateWithIdAsync")]
		public static extern IAsyncOperation<BitmapDecoder> CreateAsync([In] Guid decoderId, [In] IRandomAccessStream stream);
	}
}
