using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[Version(100794368u)]
	public enum SystemConditionType
	{
		Invalid,
		UserPresent,
		UserNotPresent,
		InternetAvailable,
		InternetNotAvailable,
		SessionConnected,
		SessionDisconnected
	}
}
