using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[Guid(887953914u, 33668, 20153, 130, 9, 251, 80, 148, 238, 236, 53), Version(100794368u), WebHostHidden]
	public delegate void TimerDestroyedHandler([In] ThreadPoolTimer timer);
}
