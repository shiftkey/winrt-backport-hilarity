using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(KeyDerivationAlgorithmProvider)), Guid(3791366203u, 18033, 17335, 145, 88, 118, 58, 170, 152, 182, 191), Version(100794368u)]
	internal interface IKeyDerivationAlgorithmProvider
	{
		string AlgorithmName
		{
			get;
		}
		CryptographicKey CreateKey([In] IBuffer keyMaterial);
	}
}
