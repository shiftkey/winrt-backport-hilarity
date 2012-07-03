using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(ProvisioningAgent)), Guid(561447136u, 33281, 4575, 173, 185, 244, 206, 70, 45, 145, 55), Version(100794368u)]
	internal interface IProvisioningAgent
	{
		IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync([In] string provisioningXmlDocument);
		ProvisionedProfile GetProvisionedProfile([In] ProfileMediaType mediaType, [In] string profileName);
	}
}
