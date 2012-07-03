using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(HashAlgorithmProvider)), Guid(2678888257u, 23748, 17206, 174, 56, 98, 18, 183, 90, 145, 90), Version(100794368u)]
	internal interface IHashAlgorithmProviderStatics
	{
		HashAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
