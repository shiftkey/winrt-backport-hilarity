using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[Activatable(typeof(IBitmapImageFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBitmapImageStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class BitmapImage : BitmapSource, IBitmapImage
	{
		public extern event DownloadProgressEventHandler DownloadProgress
		{
			add;
			remove;
		}
		public extern event ExceptionRoutedEventHandler ImageFailed
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler ImageOpened
		{
			add;
			remove;
		}
		public extern BitmapCreateOptions CreateOptions
		{
			get;
			set;
		}
		public extern int DecodePixelHeight
		{
			get;
			set;
		}
		public extern int DecodePixelWidth
		{
			get;
			set;
		}
		public extern Uri UriSource
		{
			get;
			set;
		}
		public static extern DependencyProperty CreateOptionsProperty
		{
			get;
		}
		public static extern DependencyProperty DecodePixelHeightProperty
		{
			get;
		}
		public static extern DependencyProperty DecodePixelWidthProperty
		{
			get;
		}
		public static extern DependencyProperty UriSourceProperty
		{
			get;
		}
		public extern BitmapImage();
		public extern BitmapImage([In] Uri uriSource);
	}
}
