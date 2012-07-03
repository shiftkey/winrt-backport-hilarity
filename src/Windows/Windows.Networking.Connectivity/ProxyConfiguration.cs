using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ProxyConfiguration : IProxyConfiguration
	{
		public extern bool CanConnectDirectly
		{
			get;
		}
		public extern IVectorView<Uri> ProxyUris
		{
			get;
		}
	}
}
