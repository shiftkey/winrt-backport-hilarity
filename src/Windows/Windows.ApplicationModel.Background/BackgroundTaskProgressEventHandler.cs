using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Guid(1189111868u, 35464, 19609, 128, 76, 118, 137, 127, 98, 119, 166), Version(100794368u)]
	public delegate void BackgroundTaskProgressEventHandler([In] BackgroundTaskRegistration sender, [In] BackgroundTaskProgressEventArgs args);
}
