using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(HashAlgorithmProvider)), Guid(3197841536u, 45763, 16939, 188, 225, 236, 144, 239, 181, 215, 181), Version(100794368u)]
	internal interface IHashAlgorithmProvider
	{
		string AlgorithmName
		{
			get;
		}
		uint HashLength
		{
			get;
		}
		IBuffer HashData([In] IBuffer data);
		CryptographicHash CreateHash();
	}
}
