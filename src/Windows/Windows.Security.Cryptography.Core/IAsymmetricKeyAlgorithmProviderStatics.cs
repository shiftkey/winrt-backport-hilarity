using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(AsymmetricKeyAlgorithmProvider)), Guid(1113316888u, 42995, 18342, 168, 210, 196, 141, 96, 51, 166, 92), Version(100794368u)]
	internal interface IAsymmetricKeyAlgorithmProviderStatics
	{
		AsymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
