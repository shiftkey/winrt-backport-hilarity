using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(BackgroundTaskDeferral)), Guid(2479625581u, 44839, 19923, 132, 110, 36, 238, 64, 202, 221, 37), Version(100794368u)]
	internal interface IBackgroundTaskDeferral
	{
		void Complete();
	}
}
