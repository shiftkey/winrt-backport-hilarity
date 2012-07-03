using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(CryptographicEngine)), Guid(2682914361u, 28663, 19589, 160, 149, 149, 235, 49, 113, 94, 185), Version(100794368u)]
	internal interface ICryptographicEngineStatics
	{
		IBuffer Encrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
		IBuffer Decrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
		EncryptedAndAuthenticatedData EncryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticatedData);
		IBuffer DecryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticationTag, [In] IBuffer authenticatedData);
		IBuffer Sign([In] CryptographicKey key, [In] IBuffer data);
		bool VerifySignature([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer signature);
		IBuffer DeriveKeyMaterial([In] CryptographicKey key, [In] KeyDerivationParameters parameters, [In] uint desiredKeySize);
	}
}
