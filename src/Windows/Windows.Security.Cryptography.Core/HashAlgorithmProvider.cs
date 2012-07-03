using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IHashAlgorithmProviderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class HashAlgorithmProvider : IHashAlgorithmProvider
	{
		public extern string AlgorithmName
		{
			get;
		}
		public extern uint HashLength
		{
			get;
		}
		public extern IBuffer HashData([In] IBuffer data);
		public extern CryptographicHash CreateHash();
		public static extern HashAlgorithmProvider OpenAlgorithm([In] string algorithm);
	}
}
