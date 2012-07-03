using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BackgroundTaskCompletedEventArgs : IBackgroundTaskCompletedEventArgs
	{
		public extern Guid InstanceId
		{
			get;
		}
		public extern void CheckResult();
	}
}
