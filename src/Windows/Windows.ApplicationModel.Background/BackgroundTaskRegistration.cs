using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBackgroundTaskRegistrationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BackgroundTaskRegistration : IBackgroundTaskRegistration
	{
		public extern event BackgroundTaskCompletedEventHandler Completed
		{
			add;
			remove;
		}
		public extern event BackgroundTaskProgressEventHandler Progress
		{
			add;
			remove;
		}
		public extern string Name
		{
			get;
		}
		public extern Guid TaskId
		{
			get;
		}
		public static extern IMapView<Guid, IBackgroundTaskRegistration> AllTasks
		{
			get;
		}
		public extern void Unregister([In] bool cancelTask);
	}
}
