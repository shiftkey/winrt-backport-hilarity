using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[Guid(4205749863u, 64491, 18891, 173, 178, 113, 24, 76, 85, 110, 67), Version(100794368u), WebHostHidden]
	public delegate void TimerElapsedHandler([In] ThreadPoolTimer timer);
}
