using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[Version(100794368u)]
	public enum CryptographicPrivateKeyBlobType
	{
		Pkcs8RawPrivateKeyInfo,
		Pkcs1RsaPrivateKey,
		BCryptPrivateKey,
		Capi1PrivateKey
	}
}
