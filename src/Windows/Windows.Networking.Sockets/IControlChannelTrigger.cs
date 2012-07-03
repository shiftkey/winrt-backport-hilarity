using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(ControlChannelTrigger)), Guid(2098475431u, 61078, 16616, 161, 153, 135, 3, 205, 150, 158, 195), Version(100794368u), WebHostHidden]
	internal interface IControlChannelTrigger : IClosable
	{
		string ControlChannelTriggerId
		{
			get;
		}
		uint CurrentKeepAliveIntervalInMinutes
		{
			get;
		}
		IBackgroundTrigger KeepAliveTrigger
		{
			get;
		}
		IBackgroundTrigger PushNotificationTrigger
		{
			get;
		}
		uint ServerKeepAliveIntervalInMinutes
		{
			get;
			set;
		}
		object TransportObject
		{
			get;
		}
		void UsingTransport([In] object transport);
		ControlChannelTriggerStatus WaitForPushEnabled();
		void DecreaseNetworkKeepAliveInterval();
		void FlushTransport();
	}
}
