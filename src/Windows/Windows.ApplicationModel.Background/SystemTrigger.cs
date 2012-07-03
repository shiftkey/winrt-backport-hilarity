using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Activatable(typeof(ISystemTriggerFactory), 100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class SystemTrigger : ISystemTrigger, IBackgroundTrigger
	{
		public extern bool OneShot
		{
			get;
		}
		public extern SystemTriggerType TriggerType
		{
			get;
		}
		public extern SystemTrigger([In] SystemTriggerType triggerType, [In] bool oneShot);
	}
}
