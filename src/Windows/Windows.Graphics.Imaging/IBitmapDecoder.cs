using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapDecoder)), Guid(2901353146u, 7540, 19601, 157, 252, 150, 32, 116, 82, 51, 230), Version(100794368u)]
	internal interface IBitmapDecoder
	{
		BitmapPropertiesView BitmapContainerProperties
		{
			get;
		}
		BitmapCodecInformation DecoderInformation
		{
			get;
		}
		uint FrameCount
		{
			get;
		}
		IAsyncOperation<ImageStream> GetPreviewAsync();
		IAsyncOperation<BitmapFrame> GetFrameAsync([In] uint frameIndex);
	}
}
