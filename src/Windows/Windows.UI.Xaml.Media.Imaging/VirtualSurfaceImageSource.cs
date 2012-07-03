using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[Activatable(typeof(IVirtualSurfaceImageSourceFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class VirtualSurfaceImageSource : SurfaceImageSource, IVirtualSurfaceImageSource
	{
		public extern VirtualSurfaceImageSource([In] int pixelWidth, [In] int pixelHeight);
		public extern VirtualSurfaceImageSource([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque);
	}
}
