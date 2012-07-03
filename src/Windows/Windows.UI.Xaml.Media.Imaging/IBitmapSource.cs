using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(BitmapSource)), Guid(601383953u, 8239, 16818, 140, 91, 168, 163, 179, 51, 128, 11), Version(100794368u), WebHostHidden]
	internal interface IBitmapSource
	{
		int PixelHeight
		{
			get;
		}
		int PixelWidth
		{
			get;
		}
		void SetSource([In] IRandomAccessStream streamSource);
	}
}
