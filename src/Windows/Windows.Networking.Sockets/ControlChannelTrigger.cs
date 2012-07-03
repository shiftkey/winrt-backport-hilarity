using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Activatable(typeof(IControlChannelTriggerFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.MTA), Version(100794368u), WebHostHidden]
	public sealed class ControlChannelTrigger : IControlChannelTrigger, IClosable
	{
		public extern string ControlChannelTriggerId
		{
			get;
		}
		public extern uint CurrentKeepAliveIntervalInMinutes
		{
			get;
		}
		public extern IBackgroundTrigger KeepAliveTrigger
		{
			get;
		}
		public extern IBackgroundTrigger PushNotificationTrigger
		{
			get;
		}
		public extern uint ServerKeepAliveIntervalInMinutes
		{
			get;
			set;
		}
		public extern object TransportObject
		{
			get;
		}
		public extern ControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes);
		public extern ControlChannelTrigger([In] string channelId, [In] uint serverKeepAliveIntervalInMinutes, [In] ControlChannelTriggerResourceType resourceRequestType);
		public extern void UsingTransport([In] object transport);
		public extern ControlChannelTriggerStatus WaitForPushEnabled();
		public extern void DecreaseNetworkKeepAliveInterval();
		public extern void FlushTransport();
		public extern void Close();
	}
}
