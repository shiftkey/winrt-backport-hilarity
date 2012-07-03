using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Version(100794368u)]
	public enum NetworkOperatorEventMessageType
	{
		Gsm,
		Cdma,
		Ussd,
		DataPlanThresholdReached,
		DataPlanReset,
		DataPlanDeleted,
		ProfileConnected,
		ProfileDisconnected,
		RegisteredRoaming,
		RegisteredHome
	}
}
