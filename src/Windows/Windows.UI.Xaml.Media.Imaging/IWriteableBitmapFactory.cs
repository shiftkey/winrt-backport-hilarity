using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(WriteableBitmap)), Guid(1432611761u, 16114, 17093, 156, 109, 28, 245, 220, 192, 65, 255), Version(100794368u), WebHostHidden]
	internal interface IWriteableBitmapFactory
	{
		WriteableBitmap CreateInstanceWithDimensions([In] int pixelWidth, [In] int pixelHeight);
	}
}
