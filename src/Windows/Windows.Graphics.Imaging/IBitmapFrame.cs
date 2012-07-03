using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Guid(1923389980u, 32897, 17293, 145, 188, 148, 236, 252, 129, 133, 198), Version(100794368u)]
	public interface IBitmapFrame
	{
		BitmapAlphaMode BitmapAlphaMode
		{
			get;
		}
		BitmapPixelFormat BitmapPixelFormat
		{
			get;
		}
		BitmapPropertiesView BitmapProperties
		{
			get;
		}
		double DpiX
		{
			get;
		}
		double DpiY
		{
			get;
		}
		uint OrientedPixelHeight
		{
			get;
		}
		uint OrientedPixelWidth
		{
			get;
		}
		uint PixelHeight
		{
			get;
		}
		uint PixelWidth
		{
			get;
		}
		IAsyncOperation<ImageStream> GetThumbnailAsync();
		[DefaultOverload, Overload("GetPixelDataAsync")]
		IAsyncOperation<PixelDataProvider> GetPixelDataAsync();
		[DefaultOverload, Overload("GetPixelDataTransformedAsync")]
		IAsyncOperation<PixelDataProvider> GetPixelDataAsync([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] BitmapTransform transform, [In] ExifOrientationMode exifOrientationMode, [In] ColorManagementMode colorManagementMode);
	}
}
