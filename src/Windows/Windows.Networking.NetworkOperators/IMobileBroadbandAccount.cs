using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandAccount)), Guid(918703309u, 52962, 17376, 166, 3, 238, 134, 163, 109, 101, 112), Version(100794368u)]
	internal interface IMobileBroadbandAccount
	{
		MobileBroadbandDeviceInformation CurrentDeviceInformation
		{
			get;
		}
		MobileBroadbandNetwork CurrentNetwork
		{
			get;
		}
		string NetworkAccountId
		{
			get;
		}
		Guid ServiceProviderGuid
		{
			get;
		}
		string ServiceProviderName
		{
			get;
		}
	}
}
