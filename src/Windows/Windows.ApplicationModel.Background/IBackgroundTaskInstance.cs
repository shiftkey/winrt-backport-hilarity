using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Guid(2254166650u, 8664, 17779, 143, 50, 146, 138, 27, 6, 65, 246), Version(100794368u)]
	public interface IBackgroundTaskInstance
	{
		event BackgroundTaskCanceledEventHandler Canceled;
		Guid InstanceId
		{
			get;
		}
		uint Progress
		{
			get;
			set;
		}
		uint SuspendedCount
		{
			get;
		}
		BackgroundTaskRegistration Task
		{
			get;
		}
		object TriggerDetails
		{
			get;
		}
		BackgroundTaskDeferral GetDeferral();
	}
}
