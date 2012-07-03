using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(typeof(IMaintenanceTriggerFactory), 100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MaintenanceTrigger : IMaintenanceTrigger, IBackgroundTrigger
	{
		public extern uint FreshnessTime
		{
			get;
		}
		public extern bool OneShot
		{
			get;
		}
		public extern MaintenanceTrigger([In] uint freshnessTime, [In] bool oneShot);
	}
}
