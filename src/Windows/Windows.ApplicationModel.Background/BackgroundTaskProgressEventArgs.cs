using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BackgroundTaskProgressEventArgs : IBackgroundTaskProgressEventArgs
	{
		public extern Guid InstanceId
		{
			get;
		}
		public extern uint Progress
		{
			get;
		}
	}
}
