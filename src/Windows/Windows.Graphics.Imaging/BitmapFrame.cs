using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class BitmapFrame : IBitmapFrame
	{
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
		public extern IAsyncOperation<ImageStream> GetThumbnailAsync();
		[DefaultOverload, Overload("GetPixelDataAsync")]
		public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync();
		[DefaultOverload, Overload("GetPixelDataTransformedAsync")]
		public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] BitmapTransform transform, [In] ExifOrientationMode exifOrientationMode, [In] ColorManagementMode colorManagementMode);
	}
}
