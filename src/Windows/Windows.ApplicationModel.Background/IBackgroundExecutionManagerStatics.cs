using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(BackgroundExecutionManager)), Guid(3894864472u, 26281, 19777, 131, 212, 180, 193, 140, 135, 184, 70), Version(100794368u)]
	internal interface IBackgroundExecutionManagerStatics
	{
		[Overload("RequestAccessAsync")]
		IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();
		[Overload("RequestAccessForApplicationAsync")]
		IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync([In] string applicationId);
		[Overload("RemoveAccess")]
		void RemoveAccess();
		[Overload("RemoveAccessForApplication")]
		void RemoveAccess([In] string applicationId);
		[Overload("GetAccessStatus")]
		BackgroundAccessStatus GetAccessStatus();
		[Overload("GetAccessStatusForApplication")]
		BackgroundAccessStatus GetAccessStatus([In] string applicationId);
	}
}
