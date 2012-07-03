using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(ControlChannelTrigger)), Guid(3662380272u, 36209, 17519, 136, 195, 185, 81, 132, 162, 214, 205), Version(100794368u), WebHostHidden]
	internal interface IControlChannelTriggerFactory
	{
		[Overload("CreateControlChannelTrigger")]
		ControlChannelTrigger CreateControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes);
		[Overload("CreateControlChannelTriggerEx")]
		ControlChannelTrigger CreateControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes, [In] ControlChannelTriggerResourceType resourceRequestType);
	}
}
