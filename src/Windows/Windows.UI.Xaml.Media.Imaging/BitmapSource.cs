using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Xaml.Media.Imaging
{
	[Composable(typeof(IBitmapSourceFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBitmapSourceStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class BitmapSource : ImageSource, IBitmapSource
	{
		public extern int PixelHeight
		{
			get;
		}
		public extern int PixelWidth
		{
			get;
		}
		public static extern DependencyProperty PixelHeightProperty
		{
			get;
		}
		public static extern DependencyProperty PixelWidthProperty
		{
			get;
		}
		protected extern BitmapSource();
		public extern void SetSource([In] IRandomAccessStream streamSource);
	}
}
