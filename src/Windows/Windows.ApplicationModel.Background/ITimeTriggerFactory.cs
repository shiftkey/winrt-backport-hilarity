using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(TimeTrigger)), Guid(952533758u, 39764, 17894, 178, 243, 38, 155, 135, 166, 247, 52), Version(100794368u)]
	internal interface ITimeTriggerFactory
	{
		TimeTrigger Create([In] uint freshnessTime, [In] bool oneShot);
	}
}
