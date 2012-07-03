using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(SystemTrigger)), Guid(3892585428u, 34705, 17785, 129, 38, 135, 236, 138, 170, 64, 122), Version(100794368u)]
	internal interface ISystemTriggerFactory
	{
		SystemTrigger Create([In] SystemTriggerType triggerType, [In] bool oneShot);
	}
}
