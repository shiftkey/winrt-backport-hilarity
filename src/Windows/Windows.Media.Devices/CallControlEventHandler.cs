using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[Guid(1500476831u, 20703, 17492, 188, 99, 77, 61, 1, 182, 25, 88), Version(100794368u)]
	public delegate void CallControlEventHandler([In] CallControl sender);
}
