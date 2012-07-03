using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(SymmetricKeyAlgorithmProvider)), Guid(2369463078u, 7991, 18719, 182, 14, 245, 67, 27, 38, 180, 131), Version(100794368u)]
	internal interface ISymmetricKeyAlgorithmProviderStatics
	{
		SymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
