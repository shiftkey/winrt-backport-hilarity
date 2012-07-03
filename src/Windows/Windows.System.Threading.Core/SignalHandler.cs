using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[Guid(2453422126u, 18209, 17422, 157, 218, 85, 182, 242, 224, 119, 16), Version(100794368u), WebHostHidden]
	public delegate void SignalHandler([In] SignalNotifier signalNotifier, [In] bool timedOut);
}
