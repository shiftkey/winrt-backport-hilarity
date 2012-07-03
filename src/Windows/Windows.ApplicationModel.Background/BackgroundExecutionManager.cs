using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Static(typeof(IBackgroundExecutionManagerStatics), 100794368u), Version(100794368u)]
	public static class BackgroundExecutionManager
	{
		[Overload("RequestAccessAsync")]
		public static extern IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();
		[Overload("RequestAccessForApplicationAsync")]
		public static extern IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync([In] string applicationId);
		[Overload("RemoveAccess")]
		public static extern void RemoveAccess();
		[Overload("RemoveAccessForApplication")]
		public static extern void RemoveAccess([In] string applicationId);
		[Overload("GetAccessStatus")]
		public static extern BackgroundAccessStatus GetAccessStatus();
		[Overload("GetAccessStatusForApplication")]
		public static extern BackgroundAccessStatus GetAccessStatus([In] string applicationId);
	}
}
