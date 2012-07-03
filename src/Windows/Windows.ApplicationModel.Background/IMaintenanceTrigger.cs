using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(MaintenanceTrigger)), Guid(1746422915u, 64546, 19685, 132, 26, 114, 57, 169, 129, 0, 71), Version(100794368u)]
	internal interface IMaintenanceTrigger : IBackgroundTrigger
	{
		uint FreshnessTime
		{
			get;
		}
		bool OneShot
		{
			get;
		}
	}
}
