using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Guid(1530456361u, 41094, 18087, 166, 120, 67, 145, 53, 130, 43, 207), Version(100794368u)]
	public delegate void BackgroundTaskCompletedEventHandler([In] BackgroundTaskRegistration sender, [In] BackgroundTaskCompletedEventArgs args);
}
