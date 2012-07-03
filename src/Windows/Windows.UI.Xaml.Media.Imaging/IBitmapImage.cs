using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(BitmapImage)), Guid(833565297u, 58292, 17453, 163, 65, 76, 2, 38, 178, 114, 91), Version(100794368u), WebHostHidden]
	internal interface IBitmapImage
	{
		event DownloadProgressEventHandler DownloadProgress;
		event ExceptionRoutedEventHandler ImageFailed;
		event RoutedEventHandler ImageOpened;
		BitmapCreateOptions CreateOptions
		{
			get;
			set;
		}
		int DecodePixelHeight
		{
			get;
			set;
		}
		int DecodePixelWidth
		{
			get;
			set;
		}
		Uri UriSource
		{
			get;
			set;
		}
	}
}
