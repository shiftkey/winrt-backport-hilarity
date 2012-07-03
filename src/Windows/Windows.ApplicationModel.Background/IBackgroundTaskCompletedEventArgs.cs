using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(BackgroundTaskCompletedEventArgs)), Guid(1448945103u, 61961, 18676, 153, 103, 43, 24, 79, 123, 251, 240), Version(100794368u)]
	internal interface IBackgroundTaskCompletedEventArgs
	{
		Guid InstanceId
		{
			get;
		}
		void CheckResult();
	}
}
