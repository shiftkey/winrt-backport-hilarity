using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(NetworkOperatorNotificationTrigger)), Guid(2416483526u, 25549, 18444, 149, 209, 110, 106, 239, 128, 30, 74), Version(100794368u)]
	internal interface INetworkOperatorNotificationTrigger : IBackgroundTrigger
	{
		string NetworkAccountId
		{
			get;
		}
	}
}
