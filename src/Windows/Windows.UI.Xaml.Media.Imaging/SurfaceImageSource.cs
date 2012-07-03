using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[Composable(typeof(ISurfaceImageSourceFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SurfaceImageSource : ImageSource, ISurfaceImageSource
	{
		public extern SurfaceImageSource([In] int pixelWidth, [In] int pixelHeight);
		public extern SurfaceImageSource([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque);
	}
}
