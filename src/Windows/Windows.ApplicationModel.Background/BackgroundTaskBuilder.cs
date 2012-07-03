using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class BackgroundTaskBuilder : IBackgroundTaskBuilder
	{
		public extern string Name
		{
			get;
			set;
		}
		public extern string TaskEntryPoint
		{
			get;
			set;
		}
		public extern BackgroundTaskBuilder();
		public extern void SetTrigger([In] IBackgroundTrigger trigger);
		public extern void AddCondition([In] IBackgroundCondition condition);
		public extern BackgroundTaskRegistration Register();
	}
}
