using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Xaml.Media.Imaging
{
	[Activatable(typeof(IWriteableBitmapFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WriteableBitmap : BitmapSource, IWriteableBitmap
	{
		public extern IBuffer PixelBuffer
		{
			get;
		}
		public extern WriteableBitmap([In] int pixelWidth, [In] int pixelHeight);
		public extern void Invalidate();
	}
}
