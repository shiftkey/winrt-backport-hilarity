using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISymmetricKeyAlgorithmProviderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SymmetricKeyAlgorithmProvider : ISymmetricKeyAlgorithmProvider
	{
		public extern string AlgorithmName
		{
			get;
		}
		public extern uint BlockLength
		{
			get;
		}
		public extern CryptographicKey CreateSymmetricKey([In] IBuffer keyMaterial);
		public static extern SymmetricKeyAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
