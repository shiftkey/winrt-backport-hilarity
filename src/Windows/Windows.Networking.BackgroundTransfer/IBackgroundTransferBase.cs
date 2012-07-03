using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Networking.BackgroundTransfer
{
	[Guid(714973776u, 51049, 17804, 175, 232, 254, 184, 212, 211, 178, 239), Version(100794368u)]
	public interface IBackgroundTransferBase
	{
		BackgroundTransferCostPolicy CostPolicy
		{
			get;
			set;
		}
		string Group
		{
			get;
			set;
		}
		string Method
		{
			get;
			set;
		}
		PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		PasswordCredential ServerCredential
		{
			get;
			set;
		}
		void SetRequestHeader([In] string headerName, [In] string headerValue);
	}
}
