using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking.NetworkOperators
{
	[Static(typeof(IHotspotAuthenticationContextStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class HotspotAuthenticationContext : IHotspotAuthenticationContext
	{
		public extern Uri AuthenticationUrl
		{
			get;
		}
		public extern NetworkAdapter NetworkAdapter
		{
			get;
		}
		public extern Uri RedirectMessageUrl
		{
			get;
		}
		public extern XmlDocument RedirectMessageXml
		{
			get;
		}
		public extern byte[] WirelessNetworkId
		{
			get;
		}
		public extern void IssueCredentials([In] string userName, [In] string password, [In] string extraParameters, [In] bool markAsManualConnectOnFailure);
		public extern void AbortAuthentication([In] bool markAsManual);
		public extern void SkipAuthentication();
		public extern void TriggerAttentionRequired([In] string packageRelativeApplicationId, [In] string applicationParameters);
		public static extern bool TryGetAuthenticationContext([In] string evenToken, out HotspotAuthenticationContext context);
	}
}
