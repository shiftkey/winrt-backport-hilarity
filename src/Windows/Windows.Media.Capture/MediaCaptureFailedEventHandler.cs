using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[Guid(538243067u, 23768, 20232, 163, 20, 13, 54, 13, 165, 159, 20), Version(100794368u)]
	public delegate void MediaCaptureFailedEventHandler([In] MediaCapture sender, [In] MediaCaptureFailedEventArgs errorEventArgs);
}
