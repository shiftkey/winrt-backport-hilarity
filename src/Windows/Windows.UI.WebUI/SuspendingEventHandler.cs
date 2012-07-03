using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[Guid(1352417948u, 30946, 18563, 171, 200, 137, 96, 220, 222, 27, 92), Version(100794368u)]
	public delegate void SuspendingEventHandler([In] object sender, [In] ISuspendingEventArgs e);
}
