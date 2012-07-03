using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(BitmapSource)), Guid(3795862030u, 54439, 18852, 160, 180, 165, 159, 221, 119, 229, 8), Version(100794368u), WebHostHidden]
	internal interface IBitmapSourceFactory
	{
		BitmapSource CreateInstance([In] object outer, out object inner);
	}
}
