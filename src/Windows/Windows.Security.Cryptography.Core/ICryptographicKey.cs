using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(CryptographicKey)), Guid(3978967920u, 36475, 16393, 132, 1, 255, 209, 166, 46, 235, 39), Version(100794368u)]
	internal interface ICryptographicKey
	{
		uint KeySize
		{
			get;
		}
		[DefaultOverload, Overload("ExportDefaultPrivateKeyBlobType")]
		IBuffer Export();
		[DefaultOverload, Overload("ExportPrivateKeyWithBlobType")]
		IBuffer Export([In] CryptographicPrivateKeyBlobType BlobType);
		[DefaultOverload, Overload("ExportDefaultPublicKeyBlobType")]
		IBuffer ExportPublicKey();
		[DefaultOverload, Overload("ExportPublicKeyWithBlobType")]
		IBuffer ExportPublicKey([In] CryptographicPublicKeyBlobType BlobType);
	}
}
