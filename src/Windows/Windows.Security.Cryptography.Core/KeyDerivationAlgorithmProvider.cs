using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKeyDerivationAlgorithmProviderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class KeyDerivationAlgorithmProvider : IKeyDerivationAlgorithmProvider
	{
		public extern string AlgorithmName
		{
			get;
		}
		public extern CryptographicKey CreateKey([In] IBuffer keyMaterial);
		public static extern KeyDerivationAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
