using System;
using Windows.Foundation.Metadata;
using Windows.Media.PlayTo;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Image)), Guid(1230730242u, 39667, 20048, 170, 144, 3, 56, 143, 48, 134, 210), Version(100794368u), WebHostHidden]
	internal interface IImage
	{
		event ExceptionRoutedEventHandler ImageFailed;
		event RoutedEventHandler ImageOpened;
		Thickness NineGrid
		{
			get;
			set;
		}
		PlayToSource PlayToSource
		{
			get;
		}
		ImageSource Source
		{
			get;
			set;
		}
		Stretch Stretch
		{
			get;
			set;
		}
	}
}
