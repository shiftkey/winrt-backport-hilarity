using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(BitmapSource)), Guid(2593954177u, 33403, 20049, 137, 27, 138, 21, 181, 17, 132, 45), Version(100794368u), WebHostHidden]
	internal interface IBitmapSourceStatics
	{
		DependencyProperty PixelHeightProperty
		{
			get;
		}
		DependencyProperty PixelWidthProperty
		{
			get;
		}
	}
}
