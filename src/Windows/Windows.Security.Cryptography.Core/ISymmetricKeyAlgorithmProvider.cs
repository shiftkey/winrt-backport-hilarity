using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(SymmetricKeyAlgorithmProvider)), Guid(1031686707u, 15312, 18690, 138, 200, 71, 13, 80, 210, 19, 118), Version(100794368u)]
	internal interface ISymmetricKeyAlgorithmProvider
	{
		string AlgorithmName
		{
			get;
		}
		uint BlockLength
		{
			get;
		}
		CryptographicKey CreateSymmetricKey([In] IBuffer keyMaterial);
	}
}
