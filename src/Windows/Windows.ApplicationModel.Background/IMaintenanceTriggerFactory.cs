using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(MaintenanceTrigger)), Guid(1262345006u, 38877, 17961, 136, 176, 176, 108, 249, 72, 42, 229), Version(100794368u)]
	internal interface IMaintenanceTriggerFactory
	{
		MaintenanceTrigger Create([In] uint freshnessTime, [In] bool oneShot);
	}
}
