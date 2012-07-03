using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(INetworkInformationStatics), 100794368u), Version(100794368u)]
	public static class NetworkInformation
	{
		public static extern event NetworkStatusChangedEventHandler NetworkStatusChanged
		{
			add;
			remove;
		}
		public static extern IVectorView<ConnectionProfile> GetConnectionProfiles();
		public static extern ConnectionProfile GetInternetConnectionProfile();
		public static extern IVectorView<LanIdentifier> GetLanIdentifiers();
		public static extern IVectorView<HostName> GetHostNames();
		public static extern IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync([In] Uri uri);
		public static extern IVectorView<EndpointPair> GetSortedEndpointPairs([In] IIterable<EndpointPair> destinationList, [In] HostNameSortOptions sortOptions);
	}
}
