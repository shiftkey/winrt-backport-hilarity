using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[Version(100794368u)]
	public enum PushNotificationType
	{
		Toast,
		Tile,
		Badge,
		Raw
	}
}
