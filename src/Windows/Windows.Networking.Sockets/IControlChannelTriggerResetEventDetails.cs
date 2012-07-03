using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Guid(1750139790u, 36548, 17150, 155, 178, 33, 233, 27, 123, 252, 177), Version(100794368u), WebHostHidden]
	public interface IControlChannelTriggerResetEventDetails
	{
		bool HardwareSlotReset
		{
			get;
		}
		ControlChannelTriggerResetReason ResetReason
		{
			get;
		}
		bool SoftwareSlotReset
		{
			get;
		}
	}
}
