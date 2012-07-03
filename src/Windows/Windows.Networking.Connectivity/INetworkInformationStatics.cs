using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(NetworkInformation)), Guid(1349843025u, 38157, 16741, 156, 21, 54, 86, 25, 72, 30, 234), Version(100794368u)]
	internal interface INetworkInformationStatics
	{
		event NetworkStatusChangedEventHandler NetworkStatusChanged;
		IVectorView<ConnectionProfile> GetConnectionProfiles();
		ConnectionProfile GetInternetConnectionProfile();
		IVectorView<LanIdentifier> GetLanIdentifiers();
		IVectorView<HostName> GetHostNames();
		IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync([In] Uri uri);
		IVectorView<EndpointPair> GetSortedEndpointPairs([In] IIterable<EndpointPair> destinationList, [In] HostNameSortOptions sortOptions);
	}
}
