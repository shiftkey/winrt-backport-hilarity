using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(ImageBrush)), Guid(2681279351u, 49450, 17555, 191, 125, 243, 168, 173, 116, 181, 84), Version(100794368u), WebHostHidden]
	internal interface IImageBrush
	{
		event ExceptionRoutedEventHandler ImageFailed;
		event RoutedEventHandler ImageOpened;
		ImageSource ImageSource
		{
			get;
			set;
		}
	}
}
