using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(BitmapImage)), Guid(3373476216u, 18448, 20062, 128, 135, 3, 103, 30, 230, 13, 133), Version(100794368u), WebHostHidden]
	internal interface IBitmapImageFactory
	{
		BitmapImage CreateInstanceWithUriSource([In] Uri uriSource);
	}
}
