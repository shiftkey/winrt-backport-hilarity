using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(ProvisioningAgent)), Guid(561447136u, 33025, 4575, 173, 185, 244, 206, 70, 45, 145, 55), Version(100794368u)]
	internal interface IProvisioningAgentStaticMethods
	{
		ProvisioningAgent CreateFromNetworkAccountId([In] string networkAccountId);
	}
}
