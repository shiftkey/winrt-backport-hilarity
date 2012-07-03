using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Version(100794368u)]
	public enum NetworkDeviceStatus
	{
		DeviceNotReady,
		DeviceReady,
		SimNotInserted,
		BadSim,
		DeviceHardwareFailure,
		AccountNotActivated,
		DeviceLocked,
		DeviceBlocked
	}
}
