using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IHashAlgorithmNamesStatics), 100794368u), Version(100794368u)]
	public static class HashAlgorithmNames
	{
		public static extern string Md5
		{
			get;
		}
		public static extern string Sha1
		{
			get;
		}
		public static extern string Sha256
		{
			get;
		}
		public static extern string Sha384
		{
			get;
		}
		public static extern string Sha512
		{
			get;
		}
	}
}
