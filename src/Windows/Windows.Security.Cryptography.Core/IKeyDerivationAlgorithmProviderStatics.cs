using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(KeyDerivationAlgorithmProvider)), Guid(170002810u, 2588, 17467, 148, 24, 185, 73, 138, 235, 22, 3), Version(100794368u)]
	internal interface IKeyDerivationAlgorithmProviderStatics
	{
		KeyDerivationAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
