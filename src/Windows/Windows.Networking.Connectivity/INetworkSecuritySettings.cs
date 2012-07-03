using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(NetworkSecuritySettings)), Guid(2090892941u, 37243, 19295, 184, 77, 40, 247, 165, 172, 84, 2), Version(100794368u)]
	internal interface INetworkSecuritySettings
	{
		NetworkAuthenticationType NetworkAuthenticationType
		{
			get;
		}
		NetworkEncryptionType NetworkEncryptionType
		{
			get;
		}
	}
}
