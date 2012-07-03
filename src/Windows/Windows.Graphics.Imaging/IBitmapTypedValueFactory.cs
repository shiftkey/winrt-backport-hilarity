using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapTypedValue)), Guid(2463872409u, 52755, 18107, 149, 69, 203, 58, 63, 99, 235, 139), Version(100794368u)]
	internal interface IBitmapTypedValueFactory
	{
		BitmapTypedValue Create([In] object value, [In] PropertyType type);
	}
}
