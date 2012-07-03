using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(MacAlgorithmProvider)), Guid(3384656199u, 52343, 19952, 158, 78, 185, 33, 224, 128, 100, 76), Version(100794368u)]
	internal interface IMacAlgorithmProviderStatics
	{
		MacAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
