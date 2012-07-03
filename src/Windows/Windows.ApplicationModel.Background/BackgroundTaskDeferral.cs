using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class BackgroundTaskDeferral : IBackgroundTaskDeferral
	{
		public extern void Complete();
	}
}
