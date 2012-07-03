using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Guid(2797910720u, 20984, 19543, 172, 63, 21, 109, 209, 104, 12, 79), Version(100794368u)]
	public delegate void BackgroundTaskCanceledEventHandler([In] IBackgroundTaskInstance sender, [In] BackgroundTaskCancellationReason reason);
}
