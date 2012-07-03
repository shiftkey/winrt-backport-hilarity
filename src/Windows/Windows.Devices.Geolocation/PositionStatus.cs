using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[Version(100794368u)]
	public enum PositionStatus
	{
		Ready,
		Initializing,
		NoData,
		Disabled,
		NotInitialized,
		NotAvailable
	}
}
