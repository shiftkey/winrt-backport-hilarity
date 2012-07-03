using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(HotspotAuthenticationContext)), Guid(3881224081u, 4099, 19941, 131, 199, 222, 97, 216, 136, 49, 208), Version(100794368u)]
	internal interface IHotspotAuthenticationContext
	{
		Uri AuthenticationUrl
		{
			get;
		}
		NetworkAdapter NetworkAdapter
		{
			get;
		}
		Uri RedirectMessageUrl
		{
			get;
		}
		XmlDocument RedirectMessageXml
		{
			get;
		}
		byte[] WirelessNetworkId
		{
			get;
		}
		void IssueCredentials([In] string userName, [In] string password, [In] string extraParameters, [In] bool markAsManualConnectOnFailure);
		void AbortAuthentication([In] bool markAsManual);
		void SkipAuthentication();
		void TriggerAttentionRequired([In] string packageRelativeApplicationId, [In] string applicationParameters);
	}
}
