using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[Version(100794368u)]
	public enum CryptographicPublicKeyBlobType
	{
		X509SubjectPublicKeyInfo,
		Pkcs1RsaPublicKey,
		BCryptPublicKey,
		Capi1PublicKey
	}
}
