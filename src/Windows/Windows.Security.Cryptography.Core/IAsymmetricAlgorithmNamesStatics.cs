using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(AsymmetricAlgorithmNames)), Guid(3405184228u, 26560, 18090, 132, 249, 117, 46, 119, 68, 159, 155), Version(100794368u)]
	internal interface IAsymmetricAlgorithmNamesStatics
	{
		string DsaSha1
		{
			get;
		}
		string DsaSha256
		{
			get;
		}
		string EcdsaP256Sha256
		{
			get;
		}
		string EcdsaP384Sha384
		{
			get;
		}
		string EcdsaP521Sha512
		{
			get;
		}
		string RsaOaepSha1
		{
			get;
		}
		string RsaOaepSha256
		{
			get;
		}
		string RsaOaepSha384
		{
			get;
		}
		string RsaOaepSha512
		{
			get;
		}
		string RsaPkcs1
		{
			get;
		}
		string RsaSignPkcs1Sha1
		{
			get;
		}
		string RsaSignPkcs1Sha256
		{
			get;
		}
		string RsaSignPkcs1Sha384
		{
			get;
		}
		string RsaSignPkcs1Sha512
		{
			get;
		}
		string RsaSignPssSha1
		{
			get;
		}
		string RsaSignPssSha256
		{
			get;
		}
		string RsaSignPssSha384
		{
			get;
		}
		string RsaSignPssSha512
		{
			get;
		}
	}
}
