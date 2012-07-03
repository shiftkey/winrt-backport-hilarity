using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKeyDerivationAlgorithmNamesStatics), 100794368u), Version(100794368u)]
	public static class KeyDerivationAlgorithmNames
	{
		public static extern string Pbkdf2Md5
		{
			get;
		}
		public static extern string Pbkdf2Sha1
		{
			get;
		}
		public static extern string Pbkdf2Sha256
		{
			get;
		}
		public static extern string Pbkdf2Sha384
		{
			get;
		}
		public static extern string Pbkdf2Sha512
		{
			get;
		}
		public static extern string Sp800108CtrHmacMd5
		{
			get;
		}
		public static extern string Sp800108CtrHmacSha1
		{
			get;
		}
		public static extern string Sp800108CtrHmacSha256
		{
			get;
		}
		public static extern string Sp800108CtrHmacSha384
		{
			get;
		}
		public static extern string Sp800108CtrHmacSha512
		{
			get;
		}
		public static extern string Sp80056aConcatMd5
		{
			get;
		}
		public static extern string Sp80056aConcatSha1
		{
			get;
		}
		public static extern string Sp80056aConcatSha256
		{
			get;
		}
		public static extern string Sp80056aConcatSha384
		{
			get;
		}
		public static extern string Sp80056aConcatSha512
		{
			get;
		}
	}
}
