using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public enum SmsDeviceStatus
	{
		Off,
		Ready,
		SimNotInserted,
		BadSim,
		DeviceFailure,
		SubscriptionNotActivated,
		DeviceLocked,
		DeviceBlocked
	}
}
