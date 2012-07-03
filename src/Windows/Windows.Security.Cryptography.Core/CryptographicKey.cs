using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CryptographicKey : ICryptographicKey
	{
		public extern uint KeySize
		{
			get;
		}
		[DefaultOverload, Overload("ExportDefaultPrivateKeyBlobType")]
		public extern IBuffer Export();
		[DefaultOverload, Overload("ExportPrivateKeyWithBlobType")]
		public extern IBuffer Export([In] CryptographicPrivateKeyBlobType BlobType);
		[DefaultOverload, Overload("ExportDefaultPublicKeyBlobType")]
		public extern IBuffer ExportPublicKey();
		[DefaultOverload, Overload("ExportPublicKeyWithBlobType")]
		public extern IBuffer ExportPublicKey([In] CryptographicPublicKeyBlobType BlobType);
	}
}
