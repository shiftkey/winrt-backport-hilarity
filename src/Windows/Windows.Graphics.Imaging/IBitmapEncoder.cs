using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapEncoder)), Guid(734292195u, 57848, 19284, 149, 232, 50, 145, 149, 81, 206, 98), Version(100794368u)]
	internal interface IBitmapEncoder
	{
		BitmapProperties BitmapContainerProperties
		{
			get;
		}
		BitmapProperties BitmapProperties
		{
			get;
		}
		BitmapTransform BitmapTransform
		{
			get;
		}
		BitmapCodecInformation EncoderInformation
		{
			get;
		}
		uint GeneratedThumbnailHeight
		{
			get;
			set;
		}
		uint GeneratedThumbnailWidth
		{
			get;
			set;
		}
		bool IsThumbnailGenerated
		{
			get;
			set;
		}
		void SetPixelData([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] uint width, [In] uint height, [In] double dpiX, [In] double dpiY, [Range(0, 2147483647)] [In] byte[] pixels);
		[DefaultOverload, Overload("GoToNextFrameAsync")]
		IAsyncAction GoToNextFrameAsync();
		[DefaultOverload, Overload("GoToNextFrameWithEncodingOptionsAsync")]
		IAsyncAction GoToNextFrameAsync([In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
		IAsyncAction FlushAsync();
	}
}
