using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.PushNotifications
{
	[ExclusiveTo(typeof(PushNotificationChannel)), Guid(724045870u, 61195, 20281, 155, 138, 163, 193, 148, 222, 112, 129), Version(100794368u)]
	internal interface IPushNotificationChannel
	{
		event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived;
		DateTime ExpirationTime
		{
			get;
		}
		string Uri
		{
			get;
		}
		void Close();
	}
}
