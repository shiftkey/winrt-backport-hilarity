using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(BackgroundTaskRegistration)), Guid(1280585577u, 45056, 17082, 160, 147, 106, 86, 60, 101, 227, 248), Version(100794368u)]
	internal interface IBackgroundTaskRegistrationStatics
	{
		IMapView<Guid, IBackgroundTaskRegistration> AllTasks
		{
			get;
		}
	}
}
