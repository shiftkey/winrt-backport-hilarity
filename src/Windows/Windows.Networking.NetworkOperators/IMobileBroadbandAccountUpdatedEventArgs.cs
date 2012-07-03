using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandAccountUpdatedEventArgs)), Guid(2076384648u, 42685, 18913, 128, 171, 107, 145, 53, 74, 87, 212), Version(100794368u)]
	internal interface IMobileBroadbandAccountUpdatedEventArgs
	{
		bool HasDeviceInformationChanged
		{
			get;
		}
		bool HasNetworkChanged
		{
			get;
		}
		string NetworkAccountId
		{
			get;
		}
	}
}
