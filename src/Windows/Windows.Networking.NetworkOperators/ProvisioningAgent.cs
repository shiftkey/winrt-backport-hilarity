using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), Static(typeof(IProvisioningAgentStaticMethods), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ProvisioningAgent : IProvisioningAgent
	{
		public extern ProvisioningAgent();
		public extern IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync([In] string provisioningXmlDocument);
		public extern ProvisionedProfile GetProvisionedProfile([In] ProfileMediaType mediaType, [In] string profileName);
		public static extern ProvisioningAgent CreateFromNetworkAccountId([In] string networkAccountId);
	}
}
