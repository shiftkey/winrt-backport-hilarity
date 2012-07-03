using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(BackgroundTaskProgressEventArgs)), Guid(4212418732u, 33586, 19722, 149, 50, 3, 234, 230, 132, 218, 49), Version(100794368u)]
	internal interface IBackgroundTaskProgressEventArgs
	{
		Guid InstanceId
		{
			get;
		}
		uint Progress
		{
			get;
		}
	}
}
