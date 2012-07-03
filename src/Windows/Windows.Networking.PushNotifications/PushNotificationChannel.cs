using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[Version(100794368u)]
	public sealed class PushNotificationChannel : IPushNotificationChannel
	{
		public extern event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived
		{
			add;
			remove;
		}
		public extern DateTime ExpirationTime
		{
			get;
		}
		public extern string Uri
		{
			get;
		}
		public extern void Close();
	}
}
