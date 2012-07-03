using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(VirtualSurfaceImageSource)), Guid(984752426u, 49068, 4576, 138, 146, 105, 228, 71, 36, 1, 155), Version(100794368u), WebHostHidden]
	internal interface IVirtualSurfaceImageSourceFactory
	{
		VirtualSurfaceImageSource CreateInstanceWithDimensions([In] int pixelWidth, [In] int pixelHeight);
		VirtualSurfaceImageSource CreateInstanceWithDimensionsAndOpacity([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque);
	}
}
