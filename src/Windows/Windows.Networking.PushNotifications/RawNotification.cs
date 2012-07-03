using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[Version(100794368u)]
	public sealed class RawNotification : IRawNotification
	{
		public extern string Content
		{
			get;
		}
	}
}
