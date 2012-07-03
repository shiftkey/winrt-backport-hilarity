using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Version(100794368u)]
	public enum SystemTriggerType
	{
		Invalid,
		SmsReceived,
		UserPresent,
		UserAway,
		NetworkStateChange,
		ControlChannelReset,
		InternetAvailable,
		SessionConnected,
		ServicingComplete,
		LockScreenApplicationAdded,
		LockScreenApplicationRemoved,
		TimeZoneChange,
		OnlineIdConnectedStateChange
	}
}
