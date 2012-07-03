using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Guid(456581191u, 35259, 16950, 150, 172, 113, 208, 18, 187, 72, 105), Version(100794368u), WebHostHidden]
	public interface IControlChannelTriggerEventDetails
	{
		ControlChannelTrigger ControlChannelTrigger
		{
			get;
		}
	}
}
