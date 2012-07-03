using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(SurfaceImageSource)), Guid(984752426u, 61285, 19039, 191, 172, 115, 153, 62, 140, 18, 201), Version(100794368u), WebHostHidden]
	internal interface ISurfaceImageSourceFactory
	{
		SurfaceImageSource CreateInstanceWithDimensions([In] int pixelWidth, [In] int pixelHeight, [In] object outer, out object inner);
		SurfaceImageSource CreateInstanceWithDimensionsAndOpacity([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque, [In] object outer, out object inner);
	}
}
