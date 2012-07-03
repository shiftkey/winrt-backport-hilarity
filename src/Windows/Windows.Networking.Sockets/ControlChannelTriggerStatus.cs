using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Version(100794368u), WebHostHidden]
	public enum ControlChannelTriggerStatus
	{
		HardwareSlotRequested,
		SoftwareSlotAllocated,
		HardwareSlotAllocated,
		PolicyError,
		SystemError,
		TransportDisconnected,
		ServiceUnavailable
	}
}
