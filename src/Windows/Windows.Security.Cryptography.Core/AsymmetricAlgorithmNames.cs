using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAsymmetricAlgorithmNamesStatics), 100794368u), Version(100794368u)]
	public static class AsymmetricAlgorithmNames
	{
		public static extern string DsaSha1
		{
			get;
		}
		public static extern string DsaSha256
		{
			get;
		}
		public static extern string EcdsaP256Sha256
		{
			get;
		}
		public static extern string EcdsaP384Sha384
		{
			get;
		}
		public static extern string EcdsaP521Sha512
		{
			get;
		}
		public static extern string RsaOaepSha1
		{
			get;
		}
		public static extern string RsaOaepSha256
		{
			get;
		}
		public static extern string RsaOaepSha384
		{
			get;
		}
		public static extern string RsaOaepSha512
		{
			get;
		}
		public static extern string RsaPkcs1
		{
			get;
		}
		public static extern string RsaSignPkcs1Sha1
		{
			get;
		}
		public static extern string RsaSignPkcs1Sha256
		{
			get;
		}
		public static extern string RsaSignPkcs1Sha384
		{
			get;
		}
		public static extern string RsaSignPkcs1Sha512
		{
			get;
		}
		public static extern string RsaSignPssSha1
		{
			get;
		}
		public static extern string RsaSignPssSha256
		{
			get;
		}
		public static extern string RsaSignPssSha384
		{
			get;
		}
		public static extern string RsaSignPssSha512
		{
			get;
		}
	}
}
