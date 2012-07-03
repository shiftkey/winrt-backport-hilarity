using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class NetworkSecuritySettings : INetworkSecuritySettings
	{
		public extern NetworkAuthenticationType NetworkAuthenticationType
		{
			get;
		}
		public extern NetworkEncryptionType NetworkEncryptionType
		{
			get;
		}
	}
}
