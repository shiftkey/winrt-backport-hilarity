using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[Static(typeof(ICameraOptionsUIStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class CameraOptionsUI
	{
		public static extern void Show([In] MediaCapture mediaCapture);
	}
}
