using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[Guid(1068404526u, 20449, 20477, 170, 186, 225, 241, 51, 125, 78, 83), Version(100794368u)]
	public delegate void RecordLimitationExceededEventHandler([In] MediaCapture sender);
}
