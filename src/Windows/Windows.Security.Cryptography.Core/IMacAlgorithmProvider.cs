using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(MacAlgorithmProvider)), Guid(1245693379u, 7357, 16846, 160, 146, 170, 11, 197, 210, 210, 245), Version(100794368u)]
	internal interface IMacAlgorithmProvider
	{
		string AlgorithmName
		{
			get;
		}
		uint MacLength
		{
			get;
		}
		CryptographicKey CreateKey([In] IBuffer keyMaterial);
	}
}
