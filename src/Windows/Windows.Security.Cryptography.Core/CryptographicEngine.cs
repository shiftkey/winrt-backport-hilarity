using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICryptographicEngineStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class CryptographicEngine
	{
		public static extern IBuffer Encrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
		public static extern IBuffer Decrypt([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer iv);
		public static extern EncryptedAndAuthenticatedData EncryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticatedData);
		public static extern IBuffer DecryptAndAuthenticate([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer nonce, [In] IBuffer authenticationTag, [In] IBuffer authenticatedData);
		public static extern IBuffer Sign([In] CryptographicKey key, [In] IBuffer data);
		public static extern bool VerifySignature([In] CryptographicKey key, [In] IBuffer data, [In] IBuffer signature);
		public static extern IBuffer DeriveKeyMaterial([In] CryptographicKey key, [In] KeyDerivationParameters parameters, [In] uint desiredKeySize);
	}
}
