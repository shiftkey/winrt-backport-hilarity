using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Xaml.Media.Imaging
{
	[ExclusiveTo(typeof(WriteableBitmap)), Guid(3205201519u, 57212, 19077, 132, 19, 161, 33, 98, 133, 131, 92), Version(100794368u), WebHostHidden]
	internal interface IWriteableBitmap
	{
		IBuffer PixelBuffer
		{
			get;
		}
		void Invalidate();
	}
}
