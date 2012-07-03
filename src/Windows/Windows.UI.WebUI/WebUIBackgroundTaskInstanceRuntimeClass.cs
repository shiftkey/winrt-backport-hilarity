using System;
using Windows.ApplicationModel.Background;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIBackgroundTaskInstanceRuntimeClass : IWebUIBackgroundTaskInstance, IBackgroundTaskInstance
	{
		public extern event BackgroundTaskCanceledEventHandler Canceled
		{
			add;
			remove;
		}
		public extern bool Succeeded
		{
			get;
			set;
		}
		public extern Guid InstanceId
		{
			get;
		}
		public extern uint Progress
		{
			get;
			set;
		}
		public extern uint SuspendedCount
		{
			get;
		}
		public extern BackgroundTaskRegistration Task
		{
			get;
		}
		public extern object TriggerDetails
		{
			get;
		}
		public extern BackgroundTaskDeferral GetDeferral();
	}
}
