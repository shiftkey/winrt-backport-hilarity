using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials.UI
{
	[Version(100794368u)]
	public enum AuthenticationProtocol
	{
		Basic,
		Digest,
		Ntlm,
		Kerberos,
		Negotiate,
		CredSsp,
		Custom
	}
}
