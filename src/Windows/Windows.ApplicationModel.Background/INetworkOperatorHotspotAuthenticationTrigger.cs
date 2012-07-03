using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Background
{
	[ExclusiveTo(typeof(NetworkOperatorHotspotAuthenticationTrigger)), Guid(3881224081u, 12289, 19941, 131, 199, 222, 97, 216, 136, 49, 208), Version(100794368u)]
	internal interface INetworkOperatorHotspotAuthenticationTrigger : IBackgroundTrigger
	{
	}
}
