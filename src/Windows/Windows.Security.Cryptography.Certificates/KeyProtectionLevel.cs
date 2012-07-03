using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[Version(134217728u)]
	public enum KeyProtectionLevel
	{
		NoConsent,
		ConsentOnly,
		ConsentWithPassword
	}
}
