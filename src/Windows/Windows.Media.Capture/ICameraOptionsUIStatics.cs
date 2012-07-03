using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(CameraOptionsUI)), Guid(990731828u, 14598, 19325, 148, 108, 123, 222, 132, 68, 153, 174), Version(100794368u)]
	internal interface ICameraOptionsUIStatics
	{
		void Show([In] MediaCapture mediaCapture);
	}
}
