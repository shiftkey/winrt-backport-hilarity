using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(BitmapImage)), Guid(2653430083u, 28904, 17276, 159, 164, 44, 191, 41, 92, 255, 132), Version(100794368u), WebHostHidden]
	internal interface IBitmapImageStatics
	{
		DependencyProperty CreateOptionsProperty
		{
			get;
		}
		DependencyProperty DecodePixelHeightProperty
		{
			get;
		}
		DependencyProperty DecodePixelWidthProperty
		{
			get;
		}
		DependencyProperty UriSourceProperty
		{
			get;
		}
	}
}
